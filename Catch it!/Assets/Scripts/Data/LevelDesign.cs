using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Level ." , menuName = "Level")]
public class LevelDesign : ScriptableObject
{
    public GameObject obstacle;
    public GameObject marble;
    public int marbleAmountToCollect;
    public Vector3[] spawnPoints;
}
