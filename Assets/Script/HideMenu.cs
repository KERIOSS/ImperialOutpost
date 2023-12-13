using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideMenu : MonoBehaviour
{
    public GameObject menu;
    public GameObject sword;
    public GameObject pistol;
    public GameObject lh;
    public GameObject rh;

    public void Hide()
	{
        menu.SetActive(false);
        Time.timeScale = 1;
        sword.SetActive(true);
        pistol.SetActive(true);
        lh.SetActive(false);
        rh.SetActive(false);

	}

}
