using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunnelBooster : MonoBehaviour
{
    public LevelDesign level;
    public int funnelBoosterAmount;
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
            funnelBoosterAmount--;
            yield return new WaitForSeconds(funnelBoosterTime);
            gameObject.SetActive(false);
        }

        if (funnelBoosterAmount > 0)
        {
            gameObject.SetActive(true);
            Debug.Log("FUNNEL APPEARED");
            StartCoroutine(FunnelBooster());

        }
    }
}
