using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerMovement : MonoBehaviour
{

    Animator anim;
    Rigidbody2D rg2d;
    float dirX, dirY;
    Vector2 mov;
    CircleCollider2D attackCollider;
    bool movePrevent;
    public int Health;
    public int maxHealth = 5;
    // Use this for initialization

    [Range(1f, 20f)]
    public float moveSpeed = 5f;
    void Start()
    {
        anim = GetComponent<Animator>();
        rg2d = GetComponent<Rigidbody2D>();
        attackCollider = transform.GetChild(0).GetComponent<CircleCollider2D>();
        attackCollider.enabled = false;
        Health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        mov = new Vector2(CrossPlatformInputManager.GetAxis("Horizontal"), CrossPlatformInputManager.GetAxis("Vertical"));
        if (Math.Abs(mov.x) < 0.05f)
            mov.x = 0;
        if (Math.Abs(mov.y) < 0.05f)
            mov.y = 0;
        
        // Debug.Log("X"+mov.x);
        //  Debug.Log("Y"+mov.y);
        /**
            dirX = CrossPlatformInputManager.GetAxis("Horizontal")* moveSpeed * Time.deltaTime;
            dirY = CrossPlatformInputManager.GetAxis("Vertical")* moveSpeed * Time.deltaTime;
            mov = new Vector2(transform.position.x + dirX, transform.position.y + dirY);
            //transform.position = new Vector2(transform.position.x + dirX, transform.position.y + dirY);
            transform.position = mov; */
        if (mov.x != 0 || mov.y != 0)
        {    
            anim.SetBool("walking", true);
        }
        else
        {
            anim.SetBool("walking", false);
        }

        anim.SetFloat("movX", mov.x);//dirX);
        anim.SetFloat("movY", mov.y);//dirY);

        SwordAttack();

        PreventMovement();

        if (Health <= 0)
        {
            Die();
        }
    }

    internal void Attacked(int v)
    {
        throw new NotImplementedException();
    }

    void SwordAttack()
    {
        //Corregir esta parte debido que el movimiento esta mal aun
        if (mov != Vector2.zero)
        {
            if (mov.x == 0 && mov.y > 0)
            {
                attackCollider.offset = new Vector2(0, 0.5f);
            }
            else
            if (mov.x == 0 && mov.y < 0)
            {
                attackCollider.offset = new Vector2(0, -0.5f);
            }
            else
            if (mov.x > 0 && mov.y == 0)
            {
                attackCollider.offset = new Vector2(0.5f, 0);
            }
            else
            if (mov.x < 0 && mov.y == 0)
            {
                attackCollider.offset = new Vector2(-0.5f, 0);
            }
        }
        //attackCollider.offset = new Vector2(mov.x / 2, mov.y / 2);

        AnimatorStateInfo stateInfo = anim.GetCurrentAnimatorStateInfo(0);
        bool attacking = stateInfo.IsName("Player_Attack");

        if (CrossPlatformInputManager.GetButtonDown("Atack") && !attacking)
        {
            anim.SetTrigger("attacking");
        }
        //Para activar el collider de la espada
        if (attacking)
        {
            float playbackTime = stateInfo.normalizedTime;
            if (playbackTime > 0.33 && playbackTime < 0.66)
            {
                attackCollider.enabled = true;
            }
            else
            {
                attackCollider.enabled = false;
            }
        }
    }


    private void FixedUpdate()
    {
        // rg2d.MovePosition(rg2d.position + mov*moveSpeed*Time.deltaTime);
        rg2d.velocity = new Vector2(mov.x * moveSpeed, mov.y * moveSpeed);//Este funciona mejor, pero aun tiene errores
    }

    void PreventMovement()
    {
        if (movePrevent)
        {
            mov = Vector2.zero;
        }
    }

    IEnumerator EnableMovementAfter(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        movePrevent = false;
    }

    void Die()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Damage(int dmg)
    {
        Health -= dmg;
    }
    public void cure(int cure)
    {
        if (Health <= 5)
        {
            Health += cure;
        }
    }
}
