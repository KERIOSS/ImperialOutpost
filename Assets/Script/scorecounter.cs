using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    public Text scoreText; // Przypisz UI Text, kt�ry b�dzie wy�wietla� wynik

    public float scorecount;

     void Start()
    {
        
    }



     void Update()
    {
        scoreText.text = "" + Mathf.Round(scorecount);
    }
}
