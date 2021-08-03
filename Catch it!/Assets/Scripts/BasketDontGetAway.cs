using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketDontGetAway : MonoBehaviour
{
    //private float xBound = 2.1f;

    private RectOffset bdr;

    private void OnGUI()
    {
        bdr = GUI.skin.button.border;
    }
    void Update()
    {
        if (transform.position.x < -bdr.left / 2.5f)
        {
            transform.position = new Vector3(-bdr.left / 2.5f, transform.position.y, transform.position.z);
        }
        else if (transform.position.x > bdr.right / 2.5f)
        {
            transform.position = new Vector3(bdr.right / 2.5f, transform.position.y, transform.position.z);
        }
    }
}
