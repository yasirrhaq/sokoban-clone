using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxController : MonoBehaviour {

    float moveBox = 1f;
   private Rigidbody2D boxRigidbody2d;
    private void Start()
    {
        boxRigidbody2d = GetComponent<Rigidbody2D>();
    }
    // Use this for initialization
    private void OnCollisionEnter2D(Collision2D collision)
    {
        boxRigidbody2d.velocity = new Vector3(moveBox, moveBox);
    }
}
