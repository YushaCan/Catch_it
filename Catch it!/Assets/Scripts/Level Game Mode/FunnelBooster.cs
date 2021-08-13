using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunnelBooster : MonoBehaviour
{
    public LevelDesign level;

    private bool isUsed = false;
   
    public int funnelBoosterAmount = 1;
    private float funnelBoosterTime = 10f;
    private void Start()
    {
        
        funnelBoosterAmount = level.funnelBooster;
        gameObject.SetActive(false);
    }
    public void UseFunnelBooster()
    {
        IEnumerator FunnelBooster()
        {
            isUsed = true;
            level.funnelBooster--;
            yield return new WaitForSeconds(funnelBoosterTime);
            gameObject.SetActive(false);
            isUsed = false;
        }

        if (level.funnelBooster > 0 && isUsed == false)
        {
            gameObject.SetActive(true);
            StartCoroutine(FunnelBooster());

        }
    }
}
