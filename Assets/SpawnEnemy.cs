using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject ReSpawnPointDestroy;
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

    // Update is called once per frame
    void Update()
    {
        if (ReSpawnPointDestroy = null)
        {
            StartCoroutine(EnemyDrop());

        }
    }
    //public void randomX()
    //{
    //    // Inicjalizacja generatora liczb losowych
    //    System.Random random = new System.Random();
    //    int randomNumberX = random.Next(-4, 4); 

    //    // Wyświetlenie wygenerowanej liczby
    //    //Debug.Log("Wygenerowana losowa liczba: " + randomNumber);
    //} 
    //public void randomY()
    //{
    //    // Inicjalizacja generatora liczb losowych
    //    System.Random random = new System.Random();
    //    int randomNumberY = random.Next(1, 5);

    //    // Wyświetlenie wygenerowanej liczby
    //    //Debug.Log("Wygenerowana losowa liczba: " + randomNumber);
    //} 
    //public void randomZ()
    //{
    //    // Inicjalizacja generatora liczb losowych
    //    System.Random random = new System.Random();
    //    int randomNumberZ = random.Next(12, 14);

    //    // Wyświetlenie wygenerowanej liczby
    //    //Debug.Log("Wygenerowana losowa liczba: " + randomNumber);
    //}

}
