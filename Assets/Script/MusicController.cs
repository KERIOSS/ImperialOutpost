using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour
{
    
    public GameObject level1;
    public GameObject level2;
    public GameObject level3;
    public GameObject level4;
    public GameObject level5;
    // Start is called before the first frame update
    void Start()
    {
        level1.SetActive(false);
        level2.SetActive(false);
        level3.SetActive(false);
        level4.SetActive(false);
        level5.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        music();
    }
    void music()
	{
        if (ScoreManager.scorecount >= 0 && ScoreManager.scorecount < 50)
        {
            level1.SetActive(true);
            level2.SetActive(false);
            level3.SetActive(false);
            level4.SetActive(false);
            level5.SetActive(false);
        }
        if (ScoreManager.scorecount >= 50 && ScoreManager.scorecount < 100)
        {
            level1.SetActive(false);
            level2.SetActive(true);
            level3.SetActive(false);
            level4.SetActive(false);
            level5.SetActive(false);
        }
        if (ScoreManager.scorecount >= 100 && ScoreManager.scorecount < 150)
        {
            level1.SetActive(false);
            level2.SetActive(false);
            level3.SetActive(true);
            level4.SetActive(false);
            level5.SetActive(false);
        }
        if (ScoreManager.scorecount >= 150 && ScoreManager.scorecount < 200)
        {
            level1.SetActive(false);
            level2.SetActive(false);
            level3.SetActive(false);
            level4.SetActive(true);
            level5.SetActive(false);
        }
        if (ScoreManager.scorecount >= 200 && ScoreManager.scorecount < 500)
        {
            level1.SetActive(false);
            level2.SetActive(false);
            level3.SetActive(false);
            level4.SetActive(false);
            level5.SetActive(true);
        }

    }
}
