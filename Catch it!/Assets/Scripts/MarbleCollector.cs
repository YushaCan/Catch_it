using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarbleCollector : MonoBehaviour
{
    public static int pickedMarbles = 0;
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        pickedMarbles++;
        Debug.Log("Picked Marbles ==> " + pickedMarbles);
    }
}
