using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraManager : MonoBehaviour {

    public GameObject camera;
    public GameObject personaje;

	
	// Update is called once per frame
	void Update () {
        //Casa
        if (personaje.transform.position.x == -54f && personaje.transform.position.y == 43.9f)
        {
            camera.GetComponent<CameraFollow>().enabled = true;
            camera.GetComponent<CameraFollow1>().enabled = false;
            camera.GetComponent<CameraFollowT1>().enabled = false;
            camera.GetComponent<CameraFollowT2>().enabled = false;
            camera.GetComponent<CameraFollowT3>().enabled = false;
            camera.GetComponent<CameraFollowT4>().enabled = false;
            camera.GetComponent<CamaraFinal>().enabled = false;
        }
        //Casa
        if (personaje.transform.position.x == -52.11f && personaje.transform.position.y == 37.79f)
        {
            camera.GetComponent<CameraFollow>().enabled = true;
            camera.GetComponent<CameraFollow1>().enabled = false;
            camera.GetComponent<CameraFollowT1>().enabled = false;
            camera.GetComponent<CameraFollowT2>().enabled = false;
            camera.GetComponent<CameraFollowT3>().enabled = false;
            camera.GetComponent<CameraFollowT4>().enabled = false;
            camera.GetComponent<CamaraFinal>().enabled = false;
        }
        //Patio
        Debug.Log(personaje.transform.position.x);
        Debug.Log(personaje.transform.position.y);
        if (personaje.transform.position.x == -52.01f && personaje.transform.position.y == 25.29f)
        {
            Debug.Log("Patio");
            camera.GetComponent<CameraFollow>().enabled = false;
            camera.GetComponent<CameraFollow1>().enabled = true;
            camera.GetComponent<CameraFollowT1>().enabled = false;
            camera.GetComponent<CameraFollowT2>().enabled = false;
            camera.GetComponent<CameraFollowT3>().enabled = false;
            camera.GetComponent<CameraFollowT4>().enabled = false;
            camera.GetComponent<CamaraFinal>().enabled = false;
        }
        //TemploCuarto1
        if (personaje.transform.position.x == -37.66f && personaje.transform.position.y == 57.14f)
        {
            camera.GetComponent<CameraFollow>().enabled = false;
            camera.GetComponent<CameraFollow1>().enabled = false;
            camera.GetComponent<CameraFollowT1>().enabled = true;
            camera.GetComponent<CameraFollowT2>().enabled = false;
            camera.GetComponent<CameraFollowT3>().enabled = false;
            camera.GetComponent<CameraFollowT4>().enabled = false;
            camera.GetComponent<CamaraFinal>().enabled = false;
        }
        //TemploCuarto2
        if (personaje.transform.position.x == -27.57f && personaje.transform.position.y == 61.57f)
        {
            camera.GetComponent<CameraFollow>().enabled = false;
            camera.GetComponent<CameraFollow1>().enabled = false;
            camera.GetComponent<CameraFollowT1>().enabled = false;
            camera.GetComponent<CameraFollowT2>().enabled = true;
            camera.GetComponent<CameraFollowT3>().enabled = false;
            camera.GetComponent<CameraFollowT4>().enabled = false;
            camera.GetComponent<CamaraFinal>().enabled = false;
        }
        //TemploCuarto3
        if ((personaje.transform.position.x == -22.96f && personaje.transform.position.y == 72.35f) || (personaje.transform.position.x == -23.31f && personaje.transform.position.y == 64.37f))
        {
            camera.GetComponent<CameraFollow>().enabled = false;
            camera.GetComponent<CameraFollow1>().enabled = false;
            camera.GetComponent<CameraFollowT1>().enabled = true;
            camera.GetComponent<CameraFollowT2>().enabled = false;
            camera.GetComponent<CameraFollowT3>().enabled = true;
            camera.GetComponent<CameraFollowT4>().enabled = false;
            camera.GetComponent<CamaraFinal>().enabled = false;
        }
        //TemploCuarto4
        if (personaje.transform.position.x == -13.37f && personaje.transform.position.y == 61.37f)
        {
            camera.GetComponent<CameraFollow>().enabled = false;
            camera.GetComponent<CameraFollow1>().enabled = false;
            camera.GetComponent<CameraFollowT1>().enabled = true;
            camera.GetComponent<CameraFollowT2>().enabled = false;
            camera.GetComponent<CameraFollowT3>().enabled = false;
            camera.GetComponent<CameraFollowT4>().enabled = true;
            camera.GetComponent<CamaraFinal>().enabled = false;
        }
        //CuartoFinal
        if (personaje.transform.position.x == -23.52f && personaje.transform.position.y == 90.09f)
        {
            camera.GetComponent<CameraFollow>().enabled = false;
            camera.GetComponent<CameraFollow1>().enabled = false;
            camera.GetComponent<CameraFollowT1>().enabled = true;
            camera.GetComponent<CameraFollowT2>().enabled = false;
            camera.GetComponent<CameraFollowT3>().enabled = false;
            camera.GetComponent<CameraFollowT4>().enabled = false;
            camera.GetComponent<CamaraFinal>().enabled = true;
        }
    }
}
