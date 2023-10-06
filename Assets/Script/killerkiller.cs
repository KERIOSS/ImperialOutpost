using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killerkiller : MonoBehaviour
{
    //[SerializeField]
    //private GameObject Kwadraty;
    //[SerializeField]
    //private float KwadratyInterwal = 4f;
    // Start is called before the first frame update
    
    void Start()
    {
        //StartCoroutine(SpawnEnemy((KwadratyInterwal, Kwadraty));
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
            Debug.Log("Trafiony");
           
        }
    }

   
    //private IEnumerator SpawnEmemy(float interval, GameObject enemy)
    //{
    //    yield return new WaitForSeconds(interval);
    //    GameObject newEnemy = Instantiate(enemy, new Vector3(3, 5, 3));
    //}

   
}
