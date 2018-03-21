using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour {

    

    Scene currScene;
    public string wantedScene;

	// Use this for initialization
	void Start ()
    {
        currScene = SceneManager.GetActiveScene();
    }
	
	// Update is called once per frame
	void Update ()
    {

	}

    public void GallerySceneLoader()
    {
        if (currScene.name != wantedScene)
        {
            SceneManager.LoadScene(wantedScene);
        }
    }

    public void ExitingGame()
    {
        Application.Quit();
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("mainmenu");
    }

    public void reloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
