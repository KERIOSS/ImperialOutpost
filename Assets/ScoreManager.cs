using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    public Text hpText;
    public static int scorecount;
    public static int hppoint;

    void Start()
    {
        scorecount = 0;
        hppoint = 100;
    }



    void Update()
    {
        scoreText.text = "Score: " + Mathf.Round(scorecount);
        hpText.text = "HP: " + Mathf.Round(hppoint);
    }

	
}
