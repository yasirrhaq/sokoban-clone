using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCondition : MonoBehaviour {

    public static WinCondition winCondition;
    public GameObject[] boxes;
    private int Goals;
    public GameObject youWinPanel;
    public HashSet<string> boxComplete;
    private void Awake()
    {
        winCondition = this;
        youWinPanel.SetActive(false);
    }

    void Start () {
        boxComplete = new HashSet<string>();
        Goals = boxes.Length;
	}
	
    public void checkWin()
    {
        if (Goals == boxComplete.Count)
        {
            youWinPanel.SetActive(true);
        }
    }
}
