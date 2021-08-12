using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleImpactSound : MonoBehaviour
{
    private AudioSource obstacleAudio;
    public AudioClip impactSound;
    private void Start()
    {
        obstacleAudio = GetComponent<AudioSource>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        obstacleAudio.PlayOneShot(impactSound, 0.2f);
    }


 
}
