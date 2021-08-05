using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Level ." , menuName = "Level")]
public class LevelDesign : ScriptableObject
{
    public GameObject obstacle;
    public GameObject marble;
    public int level;
    public int marbleAmountToCollect;
    public int marbleLooseCount;
    public Vector3[] spawnPoints;
}
