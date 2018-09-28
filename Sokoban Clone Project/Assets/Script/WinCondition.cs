using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCondition : MonoBehaviour {

    // Use this for initialization
    private int Goals;
    public GameObject YouWinPanel;

	void Start () {
        Goals = GameObject.FindGameObjectsWithTag("Goal").Length;
        Debug.Log("test " + Goals);
	}
	
	// Update is called once per frame      
    //masih kasaran
	void FixedUpdate () {
        checkWin();
	}

    private void Awake()
    {
        YouWinPanel.SetActive(false);
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
            YouWinPanel.SetActive(true);
            Debug.Log("YOU WIN!");
        }
    }
}
