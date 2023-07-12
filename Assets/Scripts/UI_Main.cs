using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class UI_Main : MonoBehaviour
{
    public GameObject mainScreen;
    // Start is called before the first frame update
    public void StartGame()
    {
        Application.LoadLevel("Level_1");
    }

    public void Exit()
    {
        Application.Quit();
    }
}
