using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowMenu : MonoBehaviour
{
    private bool active = true;
    public GameObject menu;
    // Start is called before the first frame update
    void Start()
    {
        //menu.SetActive(false);
        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
		if (active==false)
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
        if (Input.GetButtonDown("Jump"))
        {
            menu.SetActive(true);
            Debug.Log("f4t");
            Time.timeScale = 0;
            active = true;
        }
       
    }
    private void Close()
    {
   
        if (Input.GetButtonDown("Jump"))
        {
            menu.SetActive(false);
            Debug.Log("f4f");
            Time.timeScale = 1;

            active = false;

        }
    }
}
