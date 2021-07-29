using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Destroyer destroyer;
    public TextMeshProUGUI gameOverText;
    public Button restartButton;
    public bool gameOver = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame 100100100100100100
    void Update()
    {
        if (destroyer.gameOverCounter >= 3)
        {
            gameOver = true;
            Debug.Log("GAME OVER!");
            restartButton.gameObject.SetActive(true);
            gameOverText.gameObject.SetActive(true);
        }
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
