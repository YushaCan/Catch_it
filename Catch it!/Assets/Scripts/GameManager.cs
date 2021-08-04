using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public MarbleCollector score;
    //public HeartController heart;
    public SpawnMarbles SpawnTime;

    public TextMeshProUGUI nextLevelText;
    public Button nextLevelButton;
    public TextMeshProUGUI collectText;
    public LevelGameModeDestroyer levelGameMode;
    public SpawnMarbles spawnMarbles;

    public LevelDesign level;
    public TextMeshProUGUI gameOverText;
    public Button restartButton;
    public bool gameOver = false;
    void Start()
    {
        
    }

    // Update is called once per frame 100100100100100100
    void Update()
    {
        collectText.text = score.pickedMarbles + "/" + level.marbleAmountToCollect;

        if (levelGameMode.losingMarble >= 1)
        {
            gameOver = true;
            Debug.Log("GAME OVER!");
            restartButton.gameObject.SetActive(true);
            gameOverText.gameObject.SetActive(true);

        }

        if (score.pickedMarbles == level.marbleAmountToCollect)
        {
            gameOver = true;
            Debug.Log("Next Level!");
            nextLevelButton.gameObject.SetActive(true);
            nextLevelText.gameObject.SetActive(true);          
        }
    }
    public void RestartGame()
    {
        spawnMarbles.marbleCounter = 1;
        levelGameMode.losingMarble = 0;
        score.score = 0;
        score.pickedMarbles = 0;
        //heart.heart1.SetActive(true); This lines for the Infinity Game 
        //heart.heart2.SetActive(true);
        //heart.heart3.SetActive(true);
        SpawnTime.globalTime = 0;
        SpawnTime.localTime = 0;
        gameOver = false;
        restartButton.gameObject.SetActive(false);
        gameOverText.gameObject.SetActive(false);
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
