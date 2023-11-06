using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class killerkiller : MonoBehaviour
{
    //[SerializeField]
    //private GameObject Kwadraty;
    //[SerializeField]
    //private float KwadratyInterwal = 4f;
    // Start is called before the first frame update

    

    private void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
   
    }



    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("bullet"))
        {
            Destroy(collision.gameObject);
 
            ScoreManager.scorecount += 1;
        }
    }

   
    //private IEnumerator SpawnEmemy(float interval, GameObject enemy)
    //{
    //    yield return new WaitForSeconds(interval);
    //    GameObject newEnemy = Instantiate(enemy, new Vector3(3, 5, 3));
    //}

   
}
