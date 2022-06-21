using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Life_UI : MonoBehaviour
{
    public Image Show_Life_UI;
    public Sprite[] Sprite_Texture;

    // Update is called once per frame
    void Update()
    {
        if (Play_Life.Life_Num < 1)
        {
            Play_Life.Life_Num = 0;
            Show_Life_UI.enabled = false;
        }
        else
            Show_Life_UI.sprite = Sprite_Texture[Play_Life.Life_Num - 1];
    }
}
