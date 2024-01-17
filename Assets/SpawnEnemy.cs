using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject Enemy;
     int x;
     int y;
     int z;
     int EnemyCount;
    public int respawnTime;
    public int EnemyNumbers;


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
            int randomNumberY = randomY.Next(1, 6);
			System.Random randomZ = new System.Random();
			int randomNumberZ = randomZ.Next(12, 14);
			Instantiate(Enemy, new Vector3(randomNumberX, randomNumberY, randomNumberZ), Quaternion.identity);
            yield return new WaitForSeconds(respawnTime);
            
         
        }
    }
    void Update()
    {
      
    
     
    }



}
