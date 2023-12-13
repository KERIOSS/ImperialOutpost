using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowMenu : MonoBehaviour
{
    public bool active = true;
    public GameObject menu;
    public HideMenu button;
    private bool clicked = false;
    void Start()
    {
        Time.timeScale = 0;
    }
    void Update()
    {
        clicked = button.buttonActive;

        ShowSystem();
        
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
}
