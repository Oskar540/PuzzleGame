using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    private Scene currScene;
    public string wantedScene;

    // Use this for initialization
    private void Start()
    {
        currScene = SceneManager.GetActiveScene();
    }

    // Update is called once per frame
    private void Update()
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