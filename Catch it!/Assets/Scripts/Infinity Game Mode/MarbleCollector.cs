using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarbleCollector : MonoBehaviour
{
    public bool speedUp = false;
    public bool slowDown = false;
    public int pickedMarbles = 0;
    public int score = 0;
    public int scoreConstant = 100;
    public GameManager gameManager;

    public SpawnMarbles spawnMarbles;
    private void OnTriggerEnter(Collider other)
    {
        if (!gameManager.gameOver && other.gameObject.CompareTag("Marble"))
        {
            if (spawnMarbles.globalTime >= 10 && slowDown == true)
            {
                slowDown = false;
                speedUp = false;
                spawnMarbles.globalTime = 0;
            }
            else if (spawnMarbles.globalTime >= 2.5f && speedUp == true)
            {
                speedUp = false;
                slowDown = false;
                spawnMarbles.globalTime = 0;
            }
            other.gameObject.SetActive(false);
            pickedMarbles++;
            score += (pickedMarbles * scoreConstant);
        }
        else if (!gameManager.gameOver && other.gameObject.CompareTag("BlackMarble"))
        {
            spawnMarbles.globalTime = 0f;           
            other.gameObject.SetActive(false);
            pickedMarbles++;
            score += (pickedMarbles * scoreConstant);
            slowDown = false;
            speedUp = true;
        }
        else if (!gameManager.gameOver && other.gameObject.CompareTag("GreenMarble"))
        {
            spawnMarbles.globalTime = 0f;
            other.gameObject.SetActive(false);
            pickedMarbles++;
            score += (pickedMarbles * scoreConstant);
            speedUp = false;
            slowDown = true;
        }
    }
}
