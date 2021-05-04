using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoringSystem : MonoBehaviour
{
    public GameObject scoreText;
    public static int theScore;
    public GameObject ringText;
    public static int theRing;

    void Update()
    {
        scoreText.GetComponent<Text>().text = "SCORE: " + theScore;
        ringText.GetComponent<Text>().text = "RING: " + theRing;
    }
}
