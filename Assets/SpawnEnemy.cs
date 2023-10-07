using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{

    public GameObject Enemy;
    public int x;
    public int y;
    public int z;
    public int EnemyCount;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(EnemyDrop());

    }

   IEnumerator EnemyDrop()
    {
   

        while (EnemyCount < 10)
        {
            System.Random randomX = new System.Random();
            int randomNumberX = randomX.Next(-4, 4);
            System.Random randomY = new System.Random();
            int randomNumberY = randomY.Next(1, 5);
            System.Random randomZ = new System.Random();
            int randomNumberZ = randomZ.Next(12, 14);
            Instantiate(Enemy, new Vector3(randomNumberX, randomNumberY, randomNumberZ), Quaternion.identity);
            yield return new WaitForSeconds(1f);
            EnemyCount += 1;
            //x += 1;
            //y += 2;
            //z += 3;

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //public void randomX()
    //{
    //    // Inicjalizacja generatora liczb losowych
    //    System.Random random = new System.Random();
    //    int randomNumberX = random.Next(-4, 4); 

    //    // Wyœwietlenie wygenerowanej liczby
    //    //Debug.Log("Wygenerowana losowa liczba: " + randomNumber);
    //} 
    //public void randomY()
    //{
    //    // Inicjalizacja generatora liczb losowych
    //    System.Random random = new System.Random();
    //    int randomNumberY = random.Next(1, 5);

    //    // Wyœwietlenie wygenerowanej liczby
    //    //Debug.Log("Wygenerowana losowa liczba: " + randomNumber);
    //} 
    //public void randomZ()
    //{
    //    // Inicjalizacja generatora liczb losowych
    //    System.Random random = new System.Random();
    //    int randomNumberZ = random.Next(12, 14);

    //    // Wyœwietlenie wygenerowanej liczby
    //    //Debug.Log("Wygenerowana losowa liczba: " + randomNumber);
    //}

}
