using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushOnSides : MonoBehaviour
{
    private Rigidbody marbleRigidbody;
    private float xBound = 2.3f;
    [SerializeField] float forceSpeed;
    void Start()
    {
        marbleRigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        PushMarble();
    }
    public void PushMarble()
    {
        if(gameObject.transform.position.x > xBound)
        {
            marbleRigidbody.AddForce(Vector3.left * forceSpeed, ForceMode.Impulse);
        }
        else if(gameObject.transform.position.x < -xBound)
        {
            marbleRigidbody.AddForce(Vector3.right * forceSpeed, ForceMode.Impulse);
        }
    }
}
