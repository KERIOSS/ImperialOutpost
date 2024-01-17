using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class WeaponSwap2 : MonoBehaviour
{
    //public GameObject shield;
    public GameObject pistol;
    public GameObject bullet;
    public Transform spawnPoint;
    public GameObject rhand;
    //private bool menuGame = false;
    public float fireSpeed = 20;
    public InputActionProperty shoot;
    private float lastFireTime = 0f;
    private float fireCooldown = 0.5f;
    //private bool Bpistol = true;
    AudioSource pach;
    public ShowMenu activity;
    private bool menuStatus;
    void Start()
    {
        pach = GetComponent<AudioSource>();
        //shield.SetActive(false);
        pistol.SetActive(false);
        rhand.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        menuStatus = activity.active;
        if (menuStatus == true)
        {
            rhand.SetActive(true);
            pistol.SetActive(false);
        }
        else
        {
            rhand.SetActive(false);
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
