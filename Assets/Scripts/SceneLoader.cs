using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// class to handle changing of scenes in game
public class SceneLoader : MonoBehaviour {

    // method for loading the next scene
    public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    // using SceneManager.LoadScene to load the first scene "0"
    public void LoadStartScene()
    {
    SceneManager.LoadScene(0);
    }

    // Quit option that will stop the application
    public void QuitGame()
    {
        Application.Quit();
    }

}
