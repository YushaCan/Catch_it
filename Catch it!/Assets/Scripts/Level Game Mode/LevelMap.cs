using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class LevelMap : MonoBehaviour
{
    
    public static bool gameIsPaused = false;
    public GameObject pauseMenuUI;
    public GameObject pauseButton;
    public GameObject resumeButton;
    //public GameObject marbleCollectText;


    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        pauseButton.SetActive(true);
        //marbleCollectText.SetActive(true);
        Time.timeScale = 1f;
        gameIsPaused = false;
    }
    public void Pause() 
    {
        pauseMenuUI.SetActive(true);
        pauseButton.SetActive(false);
        //marbleCollectText.SetActive(false);
        Time.timeScale = 0f;
        gameIsPaused = true;
    }
}
