using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grenade_Explode : MonoBehaviour
{
    public GameObject Smoke;

    private void OnCollisionEnter(Collision collision)
    {
        if (
            collision.gameObject.tag == "Enemy_Car"
            || collision.gameObject.tag == "Enemy_Tank"
            || collision.gameObject.tag == "Rock"
        )
        {
            Instantiate(Smoke, transform.position, transform.rotation);
            Destroy(gameObject);
            Destroy(collision.gameObject, 0.3f);
        }
        else
        {
            StartCoroutine(Explode());
        }
    }

    IEnumerator Explode()
    {
        yield return new WaitForSeconds(3);
        Instantiate(Smoke, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
