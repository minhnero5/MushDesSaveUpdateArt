using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public int sceneIndex;
    public void StartGame()
    {
        SceneManager.LoadScene(sceneIndex);
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void BackToMenu()
    {
        SceneManager.LoadScene(sceneIndex);
    }
}
