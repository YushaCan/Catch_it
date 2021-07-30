using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartController : MonoBehaviour
{
    public Destroyer destroyer;
    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DecreaseHeartCount();
    }
    public void DecreaseHeartCount()
    {
        if(destroyer.gameOverCounter == 1)
        {
            heart1.SetActive(false);
        }
        else if(destroyer.gameOverCounter == 2)
        {
            heart2.SetActive(false);
        }
        else if (destroyer.gameOverCounter == 3)
        {
            heart3.SetActive(false);
        }
    }
}
