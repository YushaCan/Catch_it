using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarbleCollector : MonoBehaviour
{
    public static int pickedMarbles = 0;
    public GameManager gameManager;
    private void OnTriggerEnter(Collider other)
    {
        if (!gameManager.gameOver)
        {
            other.gameObject.SetActive(false);
            pickedMarbles++;
            Debug.Log("Picked Marbles ==> " + pickedMarbles);
        }
       
    }
}
