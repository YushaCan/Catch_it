using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMarbles : MonoBehaviour
{
    public GameObject marblePrefab;
    private float spawnPosX = 2;
    private float spawnPosY = 6;
    private float spawnPosZ = -1.915f;
    private float waitingTime = 1f;
    private float time;
    private void Start()
    {
        time = 0f;
    }
    void FixedUpdate()
    {
        time += Time.deltaTime;
        if(time >= 0.5f)
        {
            StartCoroutine(Spawn());
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
        }
        
    }
}
