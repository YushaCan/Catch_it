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

        if (transform.position.x > bdr.right / 2.6f)
        {
            marbleRigidbody.AddForce(Vector3.left * forceSpeed, ForceMode.Impulse);
        }
        else if (transform.position.x < -bdr.left / 2.6f)
        {
            marbleRigidbody.AddForce(Vector3.right * forceSpeed, ForceMode.Impulse);
        }
    }
}
