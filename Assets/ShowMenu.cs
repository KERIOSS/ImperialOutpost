using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowMenu : MonoBehaviour
{
    public bool active = true;
    public GameObject menu;
    public GameObject deathPanel;
    public HideMenu button;
    private bool clicked = false;
    private bool dead;
    void Start()
    {
        dead = false;
        Time.timeScale = 0;
    }
    void Update()
    {
        clicked = button.buttonActive;
        zeroHP();
        ShowSystem();
		if (dead ==true)
		{
            menu.SetActive(true);
            Time.timeScale = 0;
            active = true;
            ShowDeathPanel();
        }
    }
    public void ShowSystem()
	{        
        if (active == false)
        {
            Show();
        }
	    else
        {
            Close();
        }
		
    }
    private void Show()
    {
        
        if (Input.GetButtonDown("Jump")||Input.GetKeyDown(KeyCode.Space))
        {
            menu.SetActive(true);
            Debug.Log("f4t");
            Time.timeScale = 0;
            active = true;
        }
    }
    private void Close()
    {
        if (Input.GetButtonDown("Jump") || Input.GetKeyDown(KeyCode.Space) || clicked == true)
        {
            menu.SetActive(false);
            Debug.Log("f4f");
            Time.timeScale = 1;
            active = false;
        }
    }
    private void zeroHP()
	{
		if (ScoreManager.hppoint<=0)
		{
            dead = true;
		}
	}
    private void ShowDeathPanel()
	{
        deathPanel.SetActive(true);
	}
}
