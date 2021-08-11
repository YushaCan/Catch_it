using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooler : MonoBehaviour
{
    public static ObjectPooler SharedInstance;
    public List<GameObject> pooledObjects;
    public List<GameObject> marbles;
    public int amountToPool;
    private void Awake()
    {
        SharedInstance = this;

    }
    private void Start()
    {
        pooledObjects = new List<GameObject>();
        GameObject tmp;
        for (int i = 0; i < (amountToPool - 10); i++)
        {
            tmp = Instantiate(marbles[0]);
            tmp.SetActive(false);
            pooledObjects.Add(tmp);
        }
        for (int i = (amountToPool - 10); i < (amountToPool - 5); i++)
        {
            tmp = Instantiate(marbles[1]);
            tmp.SetActive(false);
            pooledObjects.Add(tmp);
        }
        for (int i = (amountToPool - 5); i < amountToPool ; i++)
        {
            tmp = Instantiate(marbles[2]);
            tmp.SetActive(false);
            pooledObjects.Add(tmp);
        }
    }
    public List<GameObject> GetPooledObject()
    {
        for (int i = 0; i < amountToPool; i++)
        {
            if (!pooledObjects[i].activeInHierarchy)
            {
                return pooledObjects;
            }
        }
        return null;
    }
}
