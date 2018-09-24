using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float movementSpeed;
    private Rigidbody2D myRigidbody2D;
	// Use this for initialization
	void Start () {
        myRigidbody2D = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        movement();
	}

    void movement() {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        myRigidbody2D.velocity = new Vector3(horizontal * movementSpeed, vertical * movementSpeed);
    }
}
