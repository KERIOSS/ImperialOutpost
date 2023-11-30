using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class WeaponSwap : MonoBehaviour
{
    public GameObject shield;
    public GameObject sword;
    public GameObject lhand;

    private bool Bsword= true;
    private bool menuGame = false;
    void Start()
    {
        shield.SetActive(false);
        sword.SetActive(false);
        lhand.SetActive(true);
    }

    void Update()
    {
        if (Input.GetButtonDown("Jump") && menuGame == true)
        {
            Debug.Log("Menu Aktywne");
            menuGame = false;
            lhand.SetActive(true);
            sword.SetActive(false);
            shield.SetActive(false);

        }
        else if (Input.GetButtonDown("Jump") && menuGame == false)
        {
            Debug.Log("Menu off");
            menuGame = true;
            lhand.SetActive(false);
            sword.SetActive(true);

        }

        if (Input.GetButtonDown("Fire3") && menuGame == true)
        {
       
          
			if (Bsword==true)
			{
                sword.SetActive(false);
                shield.SetActive(true);
                Bsword = false;
                Debug.Log("tarcza aktywowana");
            }
			else
			{
                shield.SetActive(false);
                sword.SetActive(true);
                Bsword = true;
                Debug.Log("Miecz aktywowany");
            }
			
        }
		else if (Input.GetButtonDown("Fire3") && menuGame == false)
		{
            Debug.Log("£apa active");
		}

    }


}
