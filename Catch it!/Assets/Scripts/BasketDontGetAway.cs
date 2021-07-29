using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketDontGetAway : MonoBehaviour
{
    private float xBound = 2.1f;
    void Update()
    {
        if (transform.position.x < -xBound)
        {
            transform.position = new Vector3(-xBound, transform.position.y, transform.position.z);
        }
        else if (transform.position.x > xBound)
        {
            transform.position = new Vector3(xBound, transform.position.y, transform.position.z);
        }
    }
}
