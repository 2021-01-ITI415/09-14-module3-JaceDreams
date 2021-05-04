using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndScreen : MonoBehaviour
{
    public GameObject Endscrn;
    public GameObject FPSController;
    public GameObject MainCamera;
    public GameObject Rings;
    public GameObject Score;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Endscrn.gameObject.SetActive(true);
            FPSController.gameObject.SetActive(false);
            MainCamera.gameObject.SetActive(true);
            Rings.gameObject.SetActive(false);
            Score.gameObject.SetActive(false);

        }
    }
}
