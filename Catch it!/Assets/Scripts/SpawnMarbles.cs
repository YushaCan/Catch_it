using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMarbles : MonoBehaviour
{
    public GameObject marblePrefab;
    private float spawnPosX = 2;
    private float spawnPosY = 6;
    private float spawnPosZ = -1.915f;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 spawnPos = new Vector3(Random.Range(-spawnPosX, spawnPosX), spawnPosY, spawnPosZ);
            Instantiate(marblePrefab, spawnPos, marblePrefab.transform.rotation);
        }
    }
}
