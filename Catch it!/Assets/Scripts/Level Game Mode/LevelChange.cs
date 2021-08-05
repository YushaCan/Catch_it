using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class LevelChange : MonoBehaviour
{
    public static int level = 0;
    public List<Image> images;
    // Start is called before the first frame update
    void Start()
    {
        images[level].GetComponent<Image>().color = new Color32(216, 0, 255, 255);
    }

    // Update is called once per frame
    void Update()
    {
    
    }
    public void NextLevel()
    {
        images[level].GetComponent<Image>().color = new Color32(0, 255, 19, 255);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        level++;
        images[level].GetComponent<Image>().color = new Color32(216, 0, 255, 255);
    }
}
