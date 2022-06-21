using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_Object : MonoBehaviour
{
    public float destroy_time;

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, destroy_time);
    }
}
