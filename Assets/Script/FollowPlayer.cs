using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame

    public float moveSpeed;
    public Vector3 targetPosition;


    void Update()
    {
        targetPosition = new Vector3(0, 2, 0) * moveSpeed;
    }

}
