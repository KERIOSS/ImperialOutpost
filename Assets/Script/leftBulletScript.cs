using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leftBulletScript : MonoBehaviour
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
        if (collision.gameObject.CompareTag("ChargeEnemy"))
        {
            Destroy(collision.gameObject);
            ScoreManager.scorecount += 2;

        }
        if (collision.gameObject.CompareTag("enemybullet"))
        {
            Destroy(collision.gameObject);

        }
       
    }
}
