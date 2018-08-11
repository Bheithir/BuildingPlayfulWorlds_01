using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour {

    public AudioSource sound;
    
    
    
    // Use this for initialization
    void Start () {
       

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            sound = gameObject.GetComponent<AudioSource>();
            sound.Play();
            Application.LoadLevel(Application.loadedLevel);
            Score.scoreValue = 0;
        }

    }
}
