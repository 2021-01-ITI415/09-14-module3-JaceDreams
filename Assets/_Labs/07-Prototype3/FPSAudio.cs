using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.Audio;
using Random = UnityEngine.Random;

public class FPSAudio : MonoBehaviour
{
    public AudioClip splashSound;
    

    public AudioSource audioS;

    public AudioMixerSnapshot idleSnapshot;
    public AudioMixerSnapshot auxInSnapshot;
    public AudioMixerSnapshot ambIdleSnapshot;
    public AudioMixerSnapshot ambInSnapshot;

    public LayerMask enemyMask;

    public bool enemyNear;

    private void Update()
    {
        RaycastHit[] hits = Physics.SphereCastAll(transform.position, 5f, transform.forward, 0f, enemyMask);

        if (hits.Length > 0)
        {
            enemyNear = true;
        }
        else
        {
            enemyNear = false;
        }
       
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Water Volume"))
        {
            audioS.PlayOneShot(splashSound);
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Water Volume"))
        {
            audioS.PlayOneShot(splashSound);
        }
       
    }

    
}