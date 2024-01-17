using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewEnemyFollow : MonoBehaviour
{
    public float objectSpeed ;
    private Transform player;
    private Vector3 initialPlayerPosition;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;

        if (player == null)
        {
            Debug.LogError("Nie znaleziono obiektu gracza!");
            return;
        }

        initialPlayerPosition = player.position;

        Vector3 directionToInitialPosition = initialPlayerPosition - transform.position;
        Vector3 normalizedDirection = directionToInitialPosition.normalized;
        GetComponent<Rigidbody>().velocity = normalizedDirection * objectSpeed;

        transform.rotation = Quaternion.LookRotation(normalizedDirection);
    }

    void Update()
    {
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            ScoreManager.hppoint -= 1;
        }
        if (collision.gameObject.CompareTag("target"))
        {
            Debug.Log("EnemyBulletDestroy");
            Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag("enemybullet"))
        {
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("bullet"))
        {
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("leftBullet"))
        {
            Destroy(collision.gameObject);
        }
    }
}
