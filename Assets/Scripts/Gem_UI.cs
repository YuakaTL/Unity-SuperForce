using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gem_UI : MonoBehaviour
{
    public Image[] Show_Gem_UI;
    public Sprite[] Sprite_Texture;
    public int Num = 0;

    // Update is called once per frame
    void Update()
    {
        if (Num < GetGem_Total.Get_Num)
        {
            if (Num <= 3)
            {
                Show_Gem_UI[Num].sprite = Sprite_Texture[1];
                Num++;
            }
        }
    }
}
