using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText; 

    public static int scorecount;

    void Start()
    {
        scorecount = 0;
    }



    void Update()
    {
        scoreText.text = "Score: " + Mathf.Round(scorecount);
    }

	
}
