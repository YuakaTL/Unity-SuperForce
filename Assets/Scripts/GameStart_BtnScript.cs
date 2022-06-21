using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStart_BtnScript : MonoBehaviour
{
    public void Play_Fun()
    {
        SceneManager.LoadScene("Game");
    }

    public void Exit_Fun()
    {
        Application.Quit();
    }
}
