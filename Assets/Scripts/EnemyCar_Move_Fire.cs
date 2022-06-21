using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCar_Move_Fire : MonoBehaviour
{
    public GameObject Player;
    public Rigidbody Bullet_Source;
    public GameObject Fire_Point;
    public GameObject Fire_Particle;
    public int Fire_Y = 3;
    public int Fire_Z = 30;
    public int Move_Dis_Num = 100;
    public int Fire_Dis_Num = 70;
    public GameObject Tire1;
    public GameObject Tire2;
    public GameObject Tire3;
    public GameObject Tire4;
    private float Dis;
    private float i;

    // Update is called once per frame
    void Update()
    {
        Dis = Vector3.Distance(transform.position, Player.transform.position);
        if (Dis < Move_Dis_Num)
        {
            Tire1.GetComponent<Rotate_Myself>().enabled = true;
            Tire2.GetComponent<Rotate_Myself>().enabled = true;
            Tire3.GetComponent<Rotate_Myself>().enabled = true;
            Tire4.GetComponent<Rotate_Myself>().enabled = true;
            transform.position = Vector3.MoveTowards(
                transform.position,
                Player.transform.position,
                0.06f
            );
            transform.LookAt(Player.transform);
            if (Dis < Fire_Dis_Num)
            {
                i += Time.deltaTime;
                if (i > 1.5)
                {
                    Instantiate(Fire_Particle, Fire_Point.transform.position, transform.rotation);
                    Rigidbody Bullet = Instantiate(
                        Bullet_Source,
                        Fire_Point.transform.position,
                        transform.rotation
                    );
                    Bullet.velocity = transform.TransformDirection(new Vector3(0, Fire_Y, Fire_Z));
                    i = 0;
                }
                else
                {
                    Tire1.GetComponent<Rotate_Myself>().enabled = false;
                    Tire2.GetComponent<Rotate_Myself>().enabled = false;
                    Tire3.GetComponent<Rotate_Myself>().enabled = false;
                    Tire4.GetComponent<Rotate_Myself>().enabled = false;
                }
            }
        }
    }
}
