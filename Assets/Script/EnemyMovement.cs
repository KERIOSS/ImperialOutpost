using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float rotationSpeed, move, distanceOfPlayer, fow;
    private float distance;
    public GameObject player;
   
    // Start is called before the first frame update
    void Start()
    {
       
    }
    // Update is called once per frame
    void  FixedUpdate()
    {
        distance = Vector3.Distance(player.transform.position, transform.position);
        if (distance < fow)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(transform.position - player.transform.position), rotationSpeed * Time.deltaTime);

            if (distance >= distanceOfPlayer)   
            {
                transform.position += -transform.forward * move * Time.deltaTime;
            }
        }
		if (distance<0.5)
		{
            Destroy(gameObject);
            ScoreManager.hppoint -= 1;

        }
    }

}
