using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCondition : MonoBehaviour {

    // Use this for initialization
    private int Goals;
    public GameObject youWinPanel;
    private GameObject[] boxes;
    private void Awake()
    {
        youWinPanel.SetActive(false);
    }

    void Start () {
        Goals = GameObject.FindGameObjectsWithTag("Goal").Length;
        boxes = GameObject.FindGameObjectsWithTag("Box");
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
            youWinPanel.SetActive(true);
            Debug.Log("YOU WIN!");
        }
    }
}
