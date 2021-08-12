using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Booster : MonoBehaviour
{
    public LevelDesign level;
    public int sizeBoosterAmount;
    
    private bool isUse = false;

    Vector3 temp;
    private int sizeBoosterTime = 5;
    private void Start()
    {
        sizeBoosterAmount = level.sizeBooster;
    }
    public void UseSizeBooster()
    {
        
        IEnumerator SizeBooster()
        {
            isUse = true;
            temp = transform.localScale;
            temp.x *= 2;
            transform.localScale = temp;
            sizeBoosterAmount--;
            yield return new WaitForSeconds(sizeBoosterTime);
            temp.x /= 2;
            transform.localScale = temp;
            isUse = false;
        }

        if (sizeBoosterAmount > 0 && isUse == false)
        {
            StartCoroutine(SizeBooster());
        }
    } 
}

