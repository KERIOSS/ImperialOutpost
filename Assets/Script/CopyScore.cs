using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CopyScore : MonoBehaviour
{
    // Start is called before the first frame update
    public ScoreManager score;
    public Text dScore;
    private int scoreOnDeath;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreOnDeath = score.scoreToUpload;
        Debug.Log(scoreOnDeath);
        dScore.text = "Tw�j wynik: " + scoreOnDeath;
    }
}
