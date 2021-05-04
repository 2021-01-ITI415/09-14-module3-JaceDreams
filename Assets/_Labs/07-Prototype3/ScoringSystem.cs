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
    public GameObject scoreProText;
    public static int theProScore;
    public GameObject ringProText;
    public static int theProRing;
    public GameObject gemProText;
    public static int theProGem;

    void Update()
    {
        scoreText.GetComponent<Text>().text = "SCORE: " + theScore;
        ringText.GetComponent<Text>().text = "RINGS: " + theRing;
        scoreProText.GetComponent<Text>().text = "FINAL SCORE: " + theScore;
        ringProText.GetComponent<Text>().text = "RINGS: " + theRing;
        gemProText.GetComponent<Text>().text = "HIDDEN GEMS: " + theProGem;
    }
}
