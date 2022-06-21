using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play_Life : MonoBehaviour
{
    public static int Life_Num = 10;
    public GameObject Game_Fail_UI;
    public GameObject Game_Finish_UI;

    void Start()
    {
        Life_Num = 10;
    }

    void Update()
    {
        if (Life_Num <= 0)
        {
            Game_Fail_UI.SetActive(true);
            StartCoroutine("GameFinish");
        }
        if (Life_Num > 0 && GetGem_Total.Get_Num == 4)
        {
            Game_Finish_UI.SetActive(true);
            StartCoroutine("GameFinish");
        }
    }

    IEnumerator GameFinish()
    {
        yield return new WaitForSeconds(0.6f);
        SceneManager.LoadScene("Game_Start");
    }
}
