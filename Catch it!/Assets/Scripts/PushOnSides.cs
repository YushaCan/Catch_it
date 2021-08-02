using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushOnSides : MonoBehaviour
{
    private Rigidbody marbleRigidbody;
    //private float xBound = 2.3f;
    [SerializeField] float forceSpeed;

    public void Start()
    {
        
        marbleRigidbody = GetComponent<Rigidbody>();
    }

    private void OnGUI()
    {
        RectOffset bdr;
        bdr = GUI.skin.button.border;
        Debug.Log("Left: " + bdr.left + " Right: " + bdr.right);

        if (transform.position.x > bdr.right / 2.5f)
        {
            marbleRigidbody.AddForce(Vector3.left * forceSpeed, ForceMode.Impulse);
        }
        else if (transform.position.x < -bdr.left / 2.5f)
        {
            marbleRigidbody.AddForce(Vector3.right * forceSpeed, ForceMode.Impulse);
        }
    }

/*
    public void FixedUpdate()
    {
        PushMarble();
    }
    public void PushMarble()
    {
        
        if(transform.position.x > xBound)
        {
            marbleRigidbody.AddForce(Vector3.left * forceSpeed, ForceMode.Impulse);
        }
        else if(transform.position.x < -xBound)
        {
            marbleRigidbody.AddForce(Vector3.right * forceSpeed, ForceMode.Impulse);
        }
    }
*/
}
