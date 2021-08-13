using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameOverAd : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public static bool closeAd = false;
    public static bool haveEarned = true;
    private void OnEnable()
    {
        StartCoroutine(AdBegins());
    }
    public IEnumerator AdBegins()
    {
        gameObject.SetActive(true);
        int time = 4;
        while(time > 0)
        {
            time--;
            timerText.text = "AD Begins In " + time;
            yield return new WaitForSeconds(1);        
        }

        //REWARDED AD IS HERE




        /////////////////////
        
        if(time == 0 && haveEarned)
        {
            closeAd = true;
            Debug.Log("YOU EARN 10 GOLDS");
        }
    }

    public void DecidedNotToWatch()
    {
        closeAd = true;
        haveEarned = false;
    }
}
