using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Corazon3 : MonoBehaviour {


    PlayerMovement player;   // Recuperamos al objeto jugador


    // Use this for initialization
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
    }

    // Update is called once per frame

    void OnTriggerEnter2D(Collider2D col)
    {
        // Si chocamos contra el jugador se destruye el corazon y lo cura
        if (col.CompareTag("Player"))
        {
            player.cure(3);
        }
        if (col.transform.tag == "Player")
        {
            Destroy(gameObject);
        }
    
    }
}
