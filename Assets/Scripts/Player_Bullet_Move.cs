using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Bullet_Move : MonoBehaviour
{
    // public float MoveSpeed;
    public float Destory_Time;
    public GameObject Smoke;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, Destory_Time);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (
            collision.gameObject.tag == "Enemy_Car"
            || collision.gameObject.tag == "Enemy_Tank"
            || collision.gameObject.tag == "Rock"
        )
        {
            Instantiate(Smoke, transform.position, transform.rotation);
            Destroy(collision.gameObject, 0.3f);
        }
        Destroy(gameObject);
    }
}
