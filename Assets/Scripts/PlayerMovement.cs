using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerMovement : MonoBehaviour {

    Animator anim;
    Rigidbody2D rg2d;
    float dirX, dirY;
    Vector2 mov;
    // Use this for initialization

    [Range(1f, 20f)]
    public float moveSpeed = 5f;
    void Start () {
        anim = GetComponent<Animator>();
        rg2d = GetComponent<Rigidbody2D>();
	}

    // Update is called once per frame
    void Update() {
        dirX = CrossPlatformInputManager.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        dirY = CrossPlatformInputManager.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        mov = new Vector2(transform.position.x + dirX, transform.position.y + dirY);
        //transform.position = new Vector2(transform.position.x + dirX, transform.position.y + dirY);
        transform.position = mov; 
        if(mov != Vector2.zero)
        {
            anim.SetFloat("movX", dirX);
            anim.SetFloat("movY", dirY);
            anim.SetBool("walking", true);
        }
        else
        {
            anim.SetBool("walking", false);
        }
    }
/**
    private void FixedUpdate()
    {
        rg2d.MovePosition(rg2d.position + mov*moveSpeed*Time.deltaTime);
    }
    */
}
