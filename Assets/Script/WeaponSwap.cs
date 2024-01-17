using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class WeaponSwap : MonoBehaviour
{
    //public GameObject shield;
    public GameObject pistol;
    public GameObject bullet;
    public Transform spawnPoint;
    public GameObject lhand;
    public float fireSpeed = 20;
    public InputActionProperty shoot;
    private float lastFireTime = 0f;
    private float fireCooldown = 0.5f;
    AudioSource pach;
    public ShowMenu activity;
    private bool menuStatus;
    void Start()
    {
        pach = GetComponent<AudioSource>();
        //shield.SetActive(false);
        pistol.SetActive(false);
        lhand.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        menuStatus = activity.active;
        if (menuStatus == true)
        {
            lhand.SetActive(true);
            pistol.SetActive(false);
        }
        else
        {
            lhand.SetActive(false);
            pistol.SetActive(true);
        }

        float triggerValue = shoot.action.ReadValue<float>();

        if (triggerValue > 0 && menuStatus == false)
        {
            TryFire();
        }   
    }
    void TryFire()
    {
        if (Time.time - lastFireTime > fireCooldown)
        {
            Fire();
            lastFireTime = Time.time;
            FireSound();
        }
    }
    void FireSound()
    {
        pach.Play();
    }
    void Fire()
    {
        GameObject spawnedbullet = Instantiate(bullet);
        spawnedbullet.transform.position = spawnPoint.position;
        spawnedbullet.GetComponent<Rigidbody>().velocity = spawnPoint.forward * fireSpeed;
        Destroy(spawnedbullet, 5);
    }
}
