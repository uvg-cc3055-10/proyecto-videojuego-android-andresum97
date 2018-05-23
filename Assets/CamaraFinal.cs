﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraFinal : MonoBehaviour {

    public GameObject follow;
    public Vector2 minCamPos, maxCamPos;
    public float smoothtime;

    private Vector2 velocity;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float posX = Mathf.SmoothDamp(transform.position.x,
            follow.transform.position.x, ref velocity.x, smoothtime);
        float posY = Mathf.SmoothDamp(transform.position.y,
            follow.transform.position.y, ref velocity.y, smoothtime);

        transform.position = new Vector3(
            Mathf.Clamp(posX, minCamPos.x, maxCamPos.x),
            Mathf.Clamp(posY, minCamPos.y, maxCamPos.y),
            transform.position.z);
    }
}
