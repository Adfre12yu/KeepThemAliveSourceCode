using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneLoader : MonoBehaviour
{
    public void LoadMainMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void QuitGame()
    {
        Application.Quit();
    }

    public void LoadGameLevel()
    {
        SceneManager.LoadScene(1);
    }
    public void LoadEndScreenOne()
    {
        SceneManager.LoadScene(2);
    }
    public void LoadEndScreenTwo()
    {
        SceneManager.LoadScene(3);
    }
    public void LoadTutorialScene()
    {
        SceneManager.LoadScene(4);
    }

}
