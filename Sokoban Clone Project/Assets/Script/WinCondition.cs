using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCondition : MonoBehaviour {

    // Use this for initialization
    private int Goals;
	void Start () {
        Goals = GameObject.FindGameObjectsWithTag("Goal").Length;
        Debug.Log("test " + Goals);
	}
	
	// Update is called once per frame
    //masih kasaran
	void FixedUpdate () {
        checkWin();
	}
    public void checkWin()
    {
        int currentGoals = 0;
        GameObject[] boxes = GameObject.FindGameObjectsWithTag("Box");
        foreach (GameObject box in boxes)
        {
            if (box.GetComponent<BoxController>().onGoal)
            {
                currentGoals += 1;
                Debug.Log(currentGoals + "horee");
            }
        }
        if (currentGoals == Goals )
        {
            Debug.Log("YOU WIN!");
        }
    }
}
