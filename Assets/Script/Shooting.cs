using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class Shooting : MonoBehaviour
{
    public GameObject bullet;
    public Transform spawnPoint;
    public float fireSpeed = 20;
    // Start is called before the first frame update
    void Start()
    {
        //XRGrabInteractable weapon = GetComponent<XRGrabInteractable>();
        //weapon.activated.AddListener(Fire);
    }

    private void Fire(ActivateEventArgs arg0)
    {
        GameObject spawnedbullet = Instantiate(bullet);
        spawnedbullet.transform.position = spawnPoint.position;
        spawnedbullet.GetComponent<Rigidbody>().velocity = spawnPoint.forward * fireSpeed;
        Destroy(spawnedbullet, 5);
    }

    // Update is called once per frame
    void Update()
    {
      
    }
}
