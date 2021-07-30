using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreCounter : MonoBehaviour
{
    public MarbleCollector marbleCollector;
    public GameManager gameManager;
    public TextMeshProUGUI scoreText;

    private void Start()
    {
    }
    void Update()
    {
        if (!gameManager.gameOver)
        {
            ScoreCalculator();
        }
 
    }
    public void ScoreCalculator()
    {
        scoreText.text = "Score: \n" + marbleCollector.score;
    }
}
