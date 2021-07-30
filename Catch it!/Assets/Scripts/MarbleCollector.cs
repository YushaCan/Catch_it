using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarbleCollector : MonoBehaviour
{
    public int pickedMarbles = 0;
    public int score = 0;
    public int scoreConstant = 100;
    public GameManager gameManager;
    private void OnTriggerEnter(Collider other)
    {
        if (!gameManager.gameOver)
        {
            other.gameObject.SetActive(false);
            pickedMarbles++;
            score += (pickedMarbles * scoreConstant);
            Debug.Log("Picked Marbles ==> " + pickedMarbles);
        }
    }
}
