using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMarbles : MonoBehaviour
{
    private float spawnPosX = 2;
    private float spawnPosY = 6;
    private float spawnPosZ = -1.915f;
    private float waitingTime = 0.2f;
    public float localTime;
    public float globalTime;
    public GameManager gameManager;
    public LevelDesign Levels;
    public int marbleCounter = 1;
    private void Start()
    {
        localTime = 0f;
        globalTime = 0f;
    }
    void FixedUpdate()
    {
        globalTime += Time.deltaTime;
        localTime += Time.deltaTime;
        if (!gameManager.gameOver && marbleCounter <= Levels.marbleLooseCount)
        {          
            TimeToSpawn();
        }
        
        
    }

    public IEnumerator Spawn()
    {
        yield return new WaitForSeconds(waitingTime);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnPosX, spawnPosX), spawnPosY, spawnPosZ);
        //Instantiate(marblePrefab, spawnPos, marblePrefab.transform.rotation);
        GameObject marble = ObjectPooler.SharedInstance.GetPooledObject();
        if (marble != null)
        {
            marble.transform.position = spawnPos;
            marble.transform.rotation = marble.transform.rotation;
            marble.SetActive(true);
            marbleCounter++;
        }
    }

    public void TimeToSpawn()
    {
        if(localTime >= 2.5f)
        {
            StartCoroutine(Spawn());
            Debug.Log("Marble Counter: " + marbleCounter);
            localTime = 0f;
        }
        
        
        
        
        /*if (localTime >= 3f && globalTime < 15)
        {
            StartCoroutine(Spawn());
            localTime = 0f;
        }
        else if(localTime >= 2f && globalTime > 15 && globalTime < 35)
        {
            StartCoroutine(Spawn());
            localTime = 0f;
        }
        else if (localTime >= 1.5f && globalTime > 35 && globalTime < 70)
        {
            StartCoroutine(Spawn());
            localTime = 0f;
        }
        else if (localTime >= 1f && globalTime > 70 && globalTime < 130)
        {
            StartCoroutine(Spawn());
            localTime = 0f;
        }
        else if (localTime >= 0.75f && globalTime > 130 && globalTime < 160)
        {
            StartCoroutine(Spawn());
            localTime = 0f;
        }
        else if (localTime >= 0.5f && globalTime > 160 && globalTime < 190)
        {
            StartCoroutine(Spawn());
            localTime = 0f;
        }
        else if (localTime >= 0.25f && globalTime > 190 && globalTime < 220)
        {
            StartCoroutine(Spawn());
            localTime = 0f;
        }
        else if (localTime >= 0.1f && globalTime > 220)
        {
            StartCoroutine(Spawn());
            localTime = 0f;
        }*/
    }
}
