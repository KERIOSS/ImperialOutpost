using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killerkiller : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
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
            Debug.Log("Trafiony");
        }
    }
}
