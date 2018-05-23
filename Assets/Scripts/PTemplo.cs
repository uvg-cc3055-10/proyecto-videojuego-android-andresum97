using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PTemplo : MonoBehaviour {

    PlayerMovement player;

    // Use this for initialization
    void Start () {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        // Si chocamos contra el jugador o un ataque la borramos
        if (col.transform.tag == "Attack")
        {
            Destroy(gameObject);
        }

    }

}
