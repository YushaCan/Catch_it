using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    public int gameOverCounter = 0;
    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.SetActive(false);
        gameOverCounter++;
        Debug.Log("FALLING MARBLES: " + gameOverCounter);    
    }
}
