using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnEnemy : MonoBehaviour
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
            int randomNumberY = randomY.Next(1, 5);
            System.Random randomZ = new System.Random();
            int randomNumberZ = randomZ.Next(12, 14);
            Instantiate(Enemy, new Vector3(randomNumberX, randomNumberY, randomNumberZ), Quaternion.identity);
            yield return new WaitForSeconds(respawnTime);
            EnemyCount += 1;
            //x += 1;
            //y += 2;
            //z += 3;

        }
    }

    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        
    }
}
