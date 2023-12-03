using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewEnemyFollow : MonoBehaviour
{
    public float bulletSpeed = 10f;
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

        // Zapami�tujemy pocz�tkow� pozycj� gracza
        initialPlayerPosition = player.position;

        // Ustawiamy pr�dko�� pocz�tkow� w kierunku punktu, w kt�rym gracz si� znajdowa�
        Vector3 directionToInitialPosition = initialPlayerPosition - transform.position;
        Vector3 normalizedDirection = directionToInitialPosition.normalized;
        GetComponent<Rigidbody>().velocity = normalizedDirection * bulletSpeed;

        // Obracamy pocisk w kierunku ruchu
        transform.rotation = Quaternion.LookRotation(normalizedDirection);
    }

    void Update()
    {
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            //Debug.Log("Gracz zosta� trafiony!");

            Destroy(gameObject);
            ScoreManager.hppoint -= 1;
        }

    }
}
