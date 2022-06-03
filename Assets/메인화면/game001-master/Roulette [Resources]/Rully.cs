using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rully : MonoBehaviour
{
    float rotSpeed = 0;

    void Update()
    {
        Rullpley();
    }
    void Rullpley ()
    {
        if(Input.GetMouseButton(0))
        {
            rotSpeed = 50;
        }

        transform.Rotate(0, 0, rotSpeed);

        rotSpeed *= 0.975f;
    }
}
