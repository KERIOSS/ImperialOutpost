using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ResetScene : MonoBehaviour
{
    public string sceneToLoad = "Main VR Scene";
    //public GameObject deadMenu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		//if (ScoreManager.hppoint<=0)
		//{
  //          Debug.Log("Reset Poziomu");
		//	SceneManager.LoadScene(sceneToLoad);
		//	//deadMenu.SetActive(true);
  // //         Time.timeScale = 0;
  //      }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("bullet"))
        {
            Destroy(collision.gameObject);

            Debug.Log("Reset Poziomu");
            SceneManager.LoadScene(sceneToLoad);


        }
    }

  

}
