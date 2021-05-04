using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoringSystem : MonoBehaviour
{
    public GameObject scoreText;
    public int theScore;
    public AudioSource collectedSound;

    void OnTriggerEnter(Collider other)
    {
        collectedSound.Play();
        theScore += 1;
        scoreText.GetComponent<Text>().text = "RINGS: " + theScore;
        Destroy(gameObject);
    }
}
