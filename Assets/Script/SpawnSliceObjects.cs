using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSliceObjects : MonoBehaviour
{
    public GameObject Enemy;
    int x;
    int y;
    int z;
    int EnemyCount;
    public int respawnTime;
    public int EnemyNumbers;

    // Start is called before the first frame update
    void Start()
    {
        new WaitForSeconds(respawnTime);
        StartCoroutine(EnemyDrop());

    }

    IEnumerator EnemyDrop()
    {


        while (EnemyCount < EnemyNumbers)
        {
            System.Random randomX = new System.Random();
            int randomNumberX = randomX.Next(-4, 4);
            System.Random randomY = new System.Random();
            int randomNumberY = randomY.Next(1, 2);
            System.Random randomZ = new System.Random();
            int randomNumberZ = randomZ.Next(5, 12);
            Instantiate(Enemy, new Vector3(randomNumberX, randomNumberY, randomNumberZ), Quaternion.identity);

            if (ScoreManager.scorecount<10)
			{
                yield return new WaitForSeconds(respawnTime);
            }
			if (ScoreManager.scorecount>10)
			{
                yield return new WaitForSeconds(respawnTime-1);
                Debug.Log(respawnTime);
            }
            if (ScoreManager.scorecount > 20)
            {
                yield return new WaitForSeconds(respawnTime -2);
                Debug.Log(respawnTime);
            }
            if (ScoreManager.scorecount > 30)
            {
                yield return new WaitForSeconds(respawnTime / 4);
                Debug.Log(respawnTime);
            }
            if (ScoreManager.scorecount > 40)
            {
                yield return new WaitForSeconds(respawnTime / 5);
                Debug.Log(respawnTime);
            }

            //EnemyCount += 1;


            //x += 1;
            //y += 2;
            //z += 3;

        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
