using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxController : MonoBehaviour
{
    public bool onGoal;
    private int count;
    private void Start()
    {
        count = GameObject.FindGameObjectsWithTag("Box").Length;
        Debug.Log("ini awal "+count);
    }

    private void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag=="Goal")
        {
            onGoal = true;
            count--;
            Debug.Log("bener");
            Debug.Log("sisa box : " + count);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        onGoal = false;
        count++;
        Debug.Log("nambah deh : " + count);
    }
}
