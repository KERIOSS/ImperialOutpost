using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAimTarget : MonoBehaviour
{
    public GameObject AimTarget;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(AimTarget, new Vector3(0, 1, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
