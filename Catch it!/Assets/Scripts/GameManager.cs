using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public MarbleCollector score;
    public SpawnMarbles SpawnTime;

    public TextMeshProUGUI nextLevelText;
    public Button nextLevelButton;
    public TextMeshProUGUI collectText;
    public LevelGameModeDestroyer levelGameMode;
    public SpawnMarbles spawnMarbles;

    public FunnelBooster funnelBooster;
    public Booster booster;

    public Button sizeBoosterButton;
    public Button funnelBoosterButton;
    public TextMeshProUGUI sizeBoosterAmountText;
    public TextMeshProUGUI funnelBoosterAmountText;

    public TextMeshProUGUI levelText;
    public LevelDesign level;
    public TextMeshProUGUI gameOverText;
    public Button restartButton;
    public bool gameOver = false;
    void Start()
    {
        levelText.text = "Level " + level.level;

    }

    void Update()
    {
        collectText.text = score.pickedMarbles + "/" + level.marbleAmountToCollect;
        sizeBoosterAmountText.text = "x" + booster.sizeBoosterAmount;
        funnelBoosterAmountText.text = "x" + funnelBooster.funnelBoosterAmount;
        
        PausedIsActive();
        
        if (levelGameMode.losingMarble >= (level.marbleLooseCount - level.marbleAmountToCollect))
        {
            gameOver = true;
            score.slowDown = false;
            score.speedUp = false;
            restartButton.gameObject.SetActive(true);
            gameOverText.gameObject.SetActive(true);

        }

        if (score.pickedMarbles == level.marbleAmountToCollect)
        {
            level.isLevelCompleted = true;
            gameOver = true;          
            nextLevelButton.gameObject.SetActive(true);
            nextLevelText.gameObject.SetActive(true);          
        }
    }
    public void RestartGame()
    {
        funnelBooster.funnelBoosterAmount = level.funnelBooster;
        booster.sizeBoosterAmount = level.sizeBooster;
        spawnMarbles.randomNumbers.Clear();
        spawnMarbles.marbleCounter = 1;
        levelGameMode.losingMarble = 0;
        score.score = 0;
        score.pickedMarbles = 0;
        SpawnTime.globalTime = 0;
        SpawnTime.localTime = 0;
        gameOver = false;
        restartButton.gameObject.SetActive(false);
        gameOverText.gameObject.SetActive(false);
    }
    public void PausedIsActive()
    {
        if(LevelDesign.isPaused == true)
        {
            sizeBoosterButton.gameObject.SetActive(false);
            funnelBoosterButton.gameObject.SetActive(false);
            levelText.gameObject.SetActive(false);
            collectText.gameObject.SetActive(false);
        }
        else if(LevelDesign.isPaused == false)
        {
            sizeBoosterButton.gameObject.SetActive(true);
            funnelBoosterButton.gameObject.SetActive(true);
            levelText.gameObject.SetActive(true);
            collectText.gameObject.SetActive(true);
        }
    }
}
