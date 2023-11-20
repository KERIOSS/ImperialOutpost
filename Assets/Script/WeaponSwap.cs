using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class WeaponSwap : MonoBehaviour
{
    public GameObject shield;
    public GameObject sword;
    public InputActionProperty Swap;
    public GameObject kloc;
    private bool Bsword;
    //private bool Bshield;
    void Start()
    {
        shield.SetActive(false);
        Bsword = true;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("Fire3"))
        {
            //ToggleModels();
          
			if (Bsword==true)
			{
                sword.SetActive(false);
                shield.SetActive(true);
                Bsword = false;
                Debug.Log("tarcza aktywowana");
                kloc.SetActive(false);
            }
			else
			{
                shield.SetActive(false);
                sword.SetActive(true);
                Bsword = true;
                Debug.Log("Miecz aktywowany");
                kloc.SetActive(true);
            }
			//if (Bshield==true)
			//{
   //             shield.SetActive(false);
   //             sword.SetActive(true);
   //             Bshield = false;
   //             Bsword = true;
   //             Debug.Log("Miecz aktywowany");
   //         }
        }
        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log("Przycisk3");
        }
        if (Input.GetButtonDown("Fire2"))
		{
            Debug.Log("Przycisk2");
		}
     
       
        if (Input.GetButtonDown("Jump"))
        {
            Debug.Log("Przycisk4");
        }
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
