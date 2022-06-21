using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate_Myself : MonoBehaviour
{
    public int X_Rotate = 0;
    public int Y_Rotate = 0;
    public int Z_Rotate = 0;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(
            X_Rotate * Time.deltaTime,
            Y_Rotate * Time.deltaTime,
            Z_Rotate * Time.deltaTime
        );
    }
}
