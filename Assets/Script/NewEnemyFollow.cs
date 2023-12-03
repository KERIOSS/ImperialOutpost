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

        // Zapamiêtujemy pocz¹tkow¹ pozycjê gracza
        initialPlayerPosition = player.position;

        // Ustawiamy prêdkoœæ pocz¹tkow¹ w kierunku punktu, w którym gracz siê znajdowa³
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
            //Debug.Log("Gracz zosta³ trafiony!");

            Destroy(gameObject);
            ScoreManager.hppoint -= 1;
        }

    }
}
