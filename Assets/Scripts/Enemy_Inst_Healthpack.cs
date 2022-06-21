using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Inst_Healthpack : MonoBehaviour
{
    public GameObject Healthpack;
    public GameObject Healthpack_Point;
    private int Random_Num;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Grenade" || collision.gameObject.tag == "Player_Bullet")
        {
            Random_Num = Random.Range(0, 5);
            Destroy(gameObject);
            print("Random_Num" + Random_Num);
            if (Random_Num <= 1)
                Instantiate(Healthpack, Healthpack_Point.transform.position, transform.rotation);
        }
    }
}
