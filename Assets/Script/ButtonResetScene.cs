using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonResetScene : MonoBehaviour
{
    public string sceneToLoad = "Main VR Scene";


    public void RestartScene()
	{
        SceneManager.LoadScene(sceneToLoad);
	}
}
