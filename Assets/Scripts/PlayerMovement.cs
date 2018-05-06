using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerMovement : MonoBehaviour {

    float dirX, dirY;
    // Use this for initialization

    [Range(1f, 20f)]
    public float moveSpeed = 5f;
    void Start () {
		
	}

    // Update is called once per frame
    void Update() {
        dirX = CrossPlatformInputManager.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        dirY = CrossPlatformInputManager.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.position = new Vector2(transform.position.x + dirX, transform.position.y + dirY);

    }
}
