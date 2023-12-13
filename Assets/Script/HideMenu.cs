using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideMenu : MonoBehaviour
{
    public bool buttonActive = false;
    //public GameObject menu;
    //public GameObject sword;
    //public GameObject pistol;
    //public GameObject lh;
    //public GameObject rh;


	public void Hide()
	{

        Debug.Log("hello");
        buttonActive = true;
        //menu.SetActive(false);
        //Time.timeScale = 1;
        //sword.SetActive(true);
        //pistol.SetActive(true);
        //lh.SetActive(false);
        //rh.SetActive(false);
        Invoke("diactivate", 1f);
        
	}
    private void diactivate()
	{
		if (buttonActive==true)
		{
            buttonActive = false;
		}
		else
		{
            Debug.Log("NothingToDo");
		}
	}
}
