using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTank_Move_Fire : MonoBehaviour
{
    public GameObject Player;
    public Rigidbody Bullet_Source;
    public GameObject Fire_Point;
    public GameObject Fire_Particle;
    public int Fire_Y = 5;
    public int Fire_Z = 40;
    public int Move_Dis_Num = 80;
    public int Fire_Dis_Num = 50;
    private float Dis;
    private float i;

    // Update is called once per frame
    void Update()
    {
        Dis = Vector3.Distance(transform.position, Player.transform.position);
        if (Dis < Move_Dis_Num)
        {
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
            }
        }
    }
}
