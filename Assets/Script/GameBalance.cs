using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBalance : MonoBehaviour
{
    public GameObject secondSpawner;
    public int score;
    // Start is called before the first frame update
    void Start()
    {
        secondSpawner.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
		if(ScoreManager.scorecount>score)
		{
            Debug.Log("Poziom2");
            secondSpawner.SetActive(true);
		} 
    }
}
