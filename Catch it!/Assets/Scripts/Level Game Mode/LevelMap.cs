using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class LevelMap : MonoBehaviour
{
    
    public GameObject pauseMenuUI;
    public GameObject pauseButton;
    public GameObject resumeButton;

    public DynamicListView dynamicListView;

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        pauseButton.SetActive(true);
        Time.timeScale = 1f;
        LevelDesign.isPaused = false;
    }

    public void Pause() 
    {
        if (LevelDesign.isGameOver == false)
        {
            pauseMenuUI.SetActive(true);
            pauseButton.SetActive(false);
            Time.timeScale = 0f;
            LevelDesign.isPaused = true;
        }
        
    }
}
