using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxController : MonoBehaviour
{
    public bool onGoal;
    private BoxCollider2D myBoxCollider2D;
    private Rigidbody2D myRigidbody2D;
    private void Start()
    {
        myBoxCollider2D = GetComponent<BoxCollider2D>();
        myRigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag=="Goal")
        {
            onGoal = true;
            Debug.Log("truee");
        }
    }
    /*private void OnTriggerExit2D(Collider2D collision)
    {
      onGoal = false;
        Debug.Log("falseee");
    }*/
}
