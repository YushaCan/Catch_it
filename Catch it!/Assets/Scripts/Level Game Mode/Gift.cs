using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gift : MonoBehaviour
{
    public LevelDesign level;
    private int randomBooster;
    public static int watchedAdAmount= 0;
    public void GetGift()
    {
        if(watchedAdAmount < 2)
        {
            Debug.Log("AD WATCHED");
            watchedAdAmount++;
            randomBooster = Random.Range(0, 2);

            //REWARDED AD HERE



            ///////////////////

            if (randomBooster == 1)
            {
                level.sizeBooster++;
            }
            else if (randomBooster == 0)
            {
                level.funnelBooster++;
            }
        }  
    }
}
