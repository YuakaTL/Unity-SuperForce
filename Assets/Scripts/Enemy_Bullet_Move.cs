using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Bullet_Move : MonoBehaviour
{
    public float Destory_Time = 1.5f;
    public GameObject Smoke;
    public AudioClip HitSound;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, Destory_Time);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Instantiate(Smoke, transform.position, transform.rotation);
        if (collision.gameObject.tag == "Player")
        {
            Play_Life.Life_Num -= 1;
            print(Play_Life.Life_Num);
            GetComponent<AudioSource>().PlayOneShot(HitSound);
        }
        Destroy(gameObject, 0.2f);
    }
}
