using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.Playables;


public class GameManager : MonoBehaviour
{

    public static GameManager instance;

    void Awake()
    {
        // Singleton
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }


    public void StartGame()
    {
        SceneManager.LoadSceneAsync(0);
    }

    public void ContinueGame()
    {
        //Continue Game
        SceneManager.LoadSceneAsync(1);
    }
    public void PauseGame()
    {
        //PauseGame
        Time.timeScale = 0;
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;

    }

    public void GameOver()
    {
        //Go scene GameOver
        SceneManager.LoadSceneAsync(1);
    }

    public void EndGame()
    {
        Application.Quit();
    }

    public void ReturnToMainMenu()
    {
        //GameOver to Main Menu
        SceneManager.LoadSceneAsync(0);
    }
}
