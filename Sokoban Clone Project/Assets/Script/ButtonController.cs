using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour {

    public void NextLevelButton(int index)
    {
        SceneManager.LoadScene(index);
    }
}
