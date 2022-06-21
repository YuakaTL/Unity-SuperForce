using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Fire : MonoBehaviour
{
    public Rigidbody Bullet;
    public GameObject Fire_Particle;
    public AudioClip Fire_Sound;
    public int Throw_z = 40;
    public int Throw_y = 2;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Rigidbody Bullet_clone = Instantiate(Bullet, transform.position, transform.rotation);
            Bullet_clone.velocity = transform.TransformDirection(new Vector3(0, Throw_y, Throw_z));
            GetComponent<AudioSource>().PlayOneShot(Fire_Sound);
        }
    }
}
