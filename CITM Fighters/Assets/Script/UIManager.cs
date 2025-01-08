using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static UnityEngine.Windows.WebCam.VideoCapture;

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
    public bool gameStart = false;
    public bool gameEnd = false;


    public AudioSource audioStart;
    public AudioSource audioInFight;
    public AudioSource audioEnd;


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

        if (StartGameUI != null)
        {
            StartGameUI.SetActive(false);
            Player1UI.SetActive(true);
            Player2UI.SetActive(false);
            audioStart.Play();
            audioInFight.Stop();
        }
        else {
            audioEnd.Play();
        }
    }

    void Update()
    {
        if (Player1Ready)
        {
            Player1UI.SetActive(false);
            Player2UI.SetActive(true);
        }

        if (Player2Ready)
        {
            Player2UI.SetActive(false);
        }

        if (Player1Ready && Player2Ready)
        {
            StartGameUI.SetActive(true);

        }
    }
    void OnStartGameButtonClicked()
    {
        // Start a new game and load the main game scene
        //Debug.Log("StartGame!!");
        camera.MoveCamera = true;
        Player1Ready = false;
        Player2Ready = false;
        StartGameUI.SetActive(false);
        StartCoroutine(FadeOut(audioStart, 2));
    }


    public void PlayMusicInFight()
    {

        audioInFight.Play();
    }

    public void StopMusicInFight() {
        StartCoroutine(FadeOut(audioInFight, 2));
    }

    IEnumerator FadeOut(AudioSource audioSource, float duration)
    {
        float startVolume = audioSource.volume;

        // 音量渐变过程
        while (audioSource.volume > 0)
        {
            audioSource.volume -= startVolume * Time.deltaTime / duration;  // 按照时间递减音量
            yield return null;  // 等待下一帧
        }

        // 停止播放并恢复音量
        audioSource.Stop();
        audioSource.volume = startVolume;  // 恢复初始音量
    }


    void OnNewGameButtonClicked()
    {
        // Start a new game and load the main game scene
        GameManager.instance.StartGame();
    }

    void OnQuitButtonClicked()
    {
        // Quit the application
        Application.Quit();
    }







}
