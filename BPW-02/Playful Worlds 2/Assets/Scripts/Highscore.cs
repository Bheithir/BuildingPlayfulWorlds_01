using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Highscore : MonoBehaviour {

    public static int scoreValue = 0;
    public Text score;
    public Text highscore;

    void Start()
    {
        
        highscore.text = PlayerPrefs.GetInt("Highscore", 0).ToString();
    }


    public void EnemyDestroy()
    {
        
        int number = scoreValue;
        score.text = number.ToString();
        PlayerPrefs.SetInt("Highscore", number);
    }
}
