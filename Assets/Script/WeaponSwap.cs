using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class WeaponSwap : MonoBehaviour
{
    public GameObject shield;
    public GameObject sword;
    public GameObject lhand;
    //public InputActionProperty Swap;
    private bool Bsword= true;
    private bool menuGame = false;
    //private bool Bshield;
    void Start()
    {
        shield.SetActive(false);
        sword.SetActive(false);
        lhand.SetActive(true);
    }

    // Update is called once per frame
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

  //      if (Input.GetButtonDown("Fire1"))
  //      {
  //          Debug.Log("Przycisk3");
  //      }
  //      if (Input.GetButtonDown("Fire2"))
		//{
  //          Debug.Log("Przycisk2");
		//}
     
       
  //      if (Input.GetButtonDown("Jump"))
  //      {
  //          Debug.Log("Przycisk4");
  //      }

    }

    //private void ToggleModels()
    //{
      
    //        if (handActive==true)
    //        {
    //            shield.SetActive(false);
    //            sword.SetActive(true);
    //            handActive = false;
    //            kloc.SetActive(false);
    //        }
    //        else
    //        {
    //            shield.SetActive(true);
    //            sword.SetActive(false);
    //             handActive = false;
    //           kloc.SetActive(true);
    //    }
    //        Debug.Log("wa");
        
    //}


}
