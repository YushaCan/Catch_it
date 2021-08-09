using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Level ." , menuName = "Level")]
public class LevelDesign : ScriptableObject
{
    public GameObject obstacle;
    public GameObject marble;
    
    public GameObject image;
    public bool isLevelCompleted = false;
    
    public int level;
    public int marbleAmountToCollect;
    public int marbleLooseCount;
    public int sizeBooster;
    public int funnelBooster;
    public Vector3[] spawnPoints;
}
