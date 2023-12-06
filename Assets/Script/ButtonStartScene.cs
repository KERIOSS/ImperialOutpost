using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonStartScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Button closeButton = GetComponent<Button>();
        if (closeButton != null)
        {
			// Dodajemy funkcjê obs³uguj¹c¹ zdarzenie klikniêcia przycisku
			closeButton.onClick.AddListener(SetTime);

        }
        else
        {
            Debug.LogError("Nie znaleziono komponentu Button na przycisku!");
        }
    }
    private void SetTime()
	{
        Time.timeScale = 1;

    }

    // Update is called once per frame
    void Update()
    {
 

    }



 
}
