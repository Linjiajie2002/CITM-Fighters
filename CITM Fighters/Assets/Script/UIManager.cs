using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

    // Main Menu Buttons
    public Button StartButton;
    public Button newGameButton;
    public Button quitButton;

    public GameObject StartGameUI;
    public GameObject Player1UI;
    public GameObject Player2UI;
    public SmoothCameraMovement camera;

    public InputAndRumbleManager inputManager;

    public bool Player1Ready = false;
    public bool Player2Ready = false;


    void Start()
    {
        // Add listeners for buttons
        if (StartButton != null)
            StartButton.onClick.AddListener(OnStartGameButtonClicked);
        else
            Debug.LogWarning("New Game Button is not assigned!");


        if (quitButton != null)
            quitButton.onClick.AddListener(OnQuitButtonClicked);
        else
            Debug.LogWarning("Quit Button is not assigned!");

        if (newGameButton != null)
            newGameButton.onClick.AddListener(OnNewGameButtonClicked);
        else
            Debug.LogWarning("Quit Button is not assigned!");

        StartGameUI.SetActive(false);
        Player1UI.SetActive(true);
        Player2UI.SetActive(false);


        // Set UI based on the current scene
        UpdateUIForCurrentScene();
    }

    void Update()
    {
        if (Player1Ready) {
            Player1UI.SetActive(false);
            Player2UI.SetActive(true);
        }

        if (Player2Ready)
        {
            Player2UI.SetActive(false);
        }

        if (Player1Ready && Player2Ready) {
            StartGameUI.SetActive(true);

        }
    }
    void UpdateUIForCurrentScene()
    {
      
        string currentScene = SceneManager.GetActiveScene().name;

        // Log the current scene for debugging
        Debug.Log(currentScene);

        //// Activate/deactivate UI elements based on the current scene
        //if (currentScene == "MainMenu")
        //{
        //    Debug.Log("Activating Main Menu UI");

        //    if (gameUI != null)
        //        gameUI.SetActive(false);
        //    if (gameOverUI != null)
        //        gameOverUI.SetActive(false);
        //}
        //else if (currentScene == "MainGame")
        //{
        //    Debug.Log("Activating Main Game UI");
        //    mainMenuUI.SetActive(false);
        //    settingsPanel.SetActive(false);
        //    if (gameUI != null)
        //        gameUI.SetActive(true);
        //    if (gameOverUI != null)
        //        gameOverUI.SetActive(false);
        //}
        //else if (currentScene == "GameOver")
        //{
        //    Debug.Log("Activating Game Over UI");
        //    mainMenuUI.SetActive(false);

        //    if (gameUI != null)
        //        gameUI.SetActive(false);
        //    if (gameOverUI != null)
        //        gameOverUI.SetActive(true);
        //}
        //else
        //{
        //    Debug.Log("No UI to activate for this scene");
        //}
    }



    void OnStartGameButtonClicked()
    {
        // Start a new game and load the main game scene
        Debug.Log("StartGame!!");
        camera.MoveCamera = true;
        Player1Ready = false;
        Player2Ready = false;
        StartGameUI.SetActive(false);
    }


    void OnNewGameButtonClicked()
    {
        // Start a new game and load the main game scene
        GameManager.instance.StartGame();
        SceneManager.LoadScene("MainGame");
    }

    void OnQuitButtonClicked()
    {
        // Quit the application
        Application.Quit();
    }







}
