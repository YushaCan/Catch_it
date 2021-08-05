using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooler : MonoBehaviour
{
    public static ObjectPooler SharedInstance;
    public List<GameObject> pooledObjects;
    public GameObject normalMarble;
    public GameObject blackMarble;
    public int amountToPool;
    private void Awake()
    {
        SharedInstance = this;
    }
    private void Start()
    {
        pooledObjects = new List<GameObject>();
        GameObject tmp;
        for(int i = 0; i < amountToPool; i++)
        {
            if(i % 3 == 0)
            {
                tmp = Instantiate(normalMarble);
                tmp.SetActive(false);
                pooledObjects.Add(tmp);
            }
            else if(i % 2 == 0)
            {
                tmp = Instantiate(blackMarble);
                tmp.SetActive(false);
                pooledObjects.Add(tmp);
            }
            
        }
    }
    public GameObject GetPooledObject()
    {
        for (int i = 0; i < amountToPool; i++)
        {
            if (!pooledObjects[i].activeInHierarchy)
            {
                return pooledObjects[i];
            }
        }
        return null;
    }
}
