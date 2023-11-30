using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class WeaponSwap2 : MonoBehaviour
{
    public GameObject shield;
    public GameObject pistol;
    public GameObject bullet;
    public Transform spawnPoint;
    public GameObject rhand;
    private bool menuGame = false;
    public float fireSpeed = 20;
    public InputActionProperty shoot;
    private float lastFireTime = 0f;
    private float fireCooldown = 0.5f;
    private bool Bpistol = true;
    void Start()
    {
        shield.SetActive(false);
        pistol.SetActive(false);
        rhand.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump") && menuGame == true)
        {
            Debug.Log("Menu Aktywne");
            menuGame = false;
            rhand.SetActive(true);
            pistol.SetActive(false);
            shield.SetActive(false);

        }
        else if (Input.GetButtonDown("Jump") && menuGame == false)
        {
            Debug.Log("Menu off");
            menuGame = true;
            rhand.SetActive(false);
            pistol.SetActive(true);

        }

        float triggerValue = shoot.action.ReadValue<float>();

		if (triggerValue> 0 && menuGame == true )
		{
            TryFire();
        }

        if (Input.GetButtonDown("Fire1") && menuGame == true)
        {
            //ToggleModels();

            if (Bpistol == true)
            {
                pistol.SetActive(false);
                shield.SetActive(true);
                Bpistol = false;
                Debug.Log("Tarcza aktywowana");
            }
            else
            {
                shield.SetActive(false);
                pistol.SetActive(true);
                Bpistol = true;
                Debug.Log("Pistolet aktywowany");
            }
           
        }
		else if (Input.GetButtonDown("Fire3") && menuGame == false)
        {
            Debug.Log("£apa active");
        }
    }
   void TryFire()
	{
        if (Time.time - lastFireTime > fireCooldown)
        {
            Fire(); 
            lastFireTime = Time.time;
        }
    } 
    void Fire()
	{
        GameObject spawnedbullet = Instantiate(bullet);
        spawnedbullet.transform.position = spawnPoint.position;
        spawnedbullet.GetComponent<Rigidbody>().velocity = spawnPoint.forward * fireSpeed;
        Destroy(spawnedbullet, 5);
    }
}
