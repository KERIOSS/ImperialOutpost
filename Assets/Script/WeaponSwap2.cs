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
    public float fireSpeed = 20;
    public InputActionProperty shoot;
    private float lastFireTime = 0f;
    private float fireCooldown = 1f;
    private bool Bpistol;
    //private bool Bshield;



    void Start()
    {
        shield.SetActive(false);
        Bpistol = true;
    }

    // Update is called once per frame
    void Update()
    {
        float triggerValue = shoot.action.ReadValue<float>();

		if (triggerValue> 0)
		{
            TryFire();

          
        }

        if (Input.GetButtonDown("Fire1"))
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
