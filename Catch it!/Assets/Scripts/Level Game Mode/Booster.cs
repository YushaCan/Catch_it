using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Booster : MonoBehaviour
{
    
    public int boosterAmount = 2;
    public float time;
    private void Start()
    {
        time = 0;
    }
    private void Update()
    {
        time += Time.deltaTime;
    }
    public void UseBooster()
    {
        if(boosterAmount > 0)
        {
            Debug.Log("Size INCREASED");
            //Vector3 local = collector.transform.localScale;
            transform.localScale = new Vector3(5f, 2f, 2f);
            //Vector3 world = collector.transform.lossyScale;
            boosterAmount--;
        }
    }
}
