using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyMarble : MonoBehaviour
{
    [SerializeField] float destroyPositionY = -5f;
    public static int gameOverCounter = 0;
    public bool gameOver;
    private void Update()
    {
        if(gameObject.transform.position.y <= destroyPositionY)
        {
            gameObject.SetActive(false);
            gameOverCounter++;
            Debug.Log("FALLING MARBLES: " + gameOverCounter);
        }
        if(gameOverCounter >= 3)
        {
            gameOver = true;
            Debug.Log("Game Is Over!");
        }
    }
}
