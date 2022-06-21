using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Get_Gem : MonoBehaviour
{
    public AudioClip Get_Sound;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            GetGem_Total.Get_Num += 1;
            GetComponent<AudioSource>().PlayOneShot(Get_Sound);
            Destroy(gameObject, 0.8f);
        }
    }
}
