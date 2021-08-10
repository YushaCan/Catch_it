using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacles : MonoBehaviour
{

    public LevelDesign levelDesign;
    
    void Start()
    {
        SpawnPos();
    }

    public void SpawnPos()
    {
        float x = 2.2f;
        float y = 4f;
        float z = -1.8514f;
        for (int i = 0; i < 8; i++)
        { 
            for(int j = 0; j < 8; j++)
            {
                levelDesign.spawnPoints[i] = new Vector3(x, y, z);
                Instantiate(levelDesign.obstacle, levelDesign.spawnPoints[i], new Quaternion(90, 90, 90, 90));
                x -= 0.6f;
            }
            y -= 0.7f;
            if(i % 2 == 0)
            {
                x = 2f;
            }
            else
            {
                x = 2.2f;
            }
            
        }
    }

}
