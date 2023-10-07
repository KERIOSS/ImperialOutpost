using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSliceObjects : MonoBehaviour
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
            int randomNumberY = randomY.Next(1, 2);
            System.Random randomZ = new System.Random();
            int randomNumberZ = randomZ.Next(5, 12);
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
}
