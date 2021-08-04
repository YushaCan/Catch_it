using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGameModeDestroyer : MonoBehaviour
{
    public int losingMarble = 0;
    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.SetActive(false);
        losingMarble++;
    }
}
