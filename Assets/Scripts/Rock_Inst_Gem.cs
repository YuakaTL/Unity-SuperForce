using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock_Inst_Gem : MonoBehaviour
{
    public GameObject Gem;
    public GameObject Gem_Point;
    private int Random_Num;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Grenade" || collision.gameObject.tag == "Player_Bullet")
        {
            Random_Num = Random.Range(0, 5);
            Destroy(gameObject);
            print("Random_Num" + Random_Num);
            if (Random_Num <= 1)
                Instantiate(Gem, Gem_Point.transform.position, transform.rotation);
        }
    }
}
