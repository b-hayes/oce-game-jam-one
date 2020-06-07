using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public GameObject scaryImage;
    private AudioSource scaryImageAudioSource;

    private void Start()
    {
        scaryImageAudioSource = scaryImage.GetComponent<AudioSource>();
    }

    public void Play()
    {
        GameManager.pickUpsCollected["banana"] = 0;
        GameManager.Music().Stop();
        scaryImage.SetActive(true);
    }

    private void Update()
    {
        if (scaryImage.activeSelf)
        {
            if (scaryImageAudioSource.isPlaying)
            {
                return;
            }
            GameManager.PlayGame();
            scaryImage.SetActive(false);
        }
    }

    public void Quit()
    {
        GameManager.QuitGame();
    }
    public void ShowMainMenu()
    {
        GameManager.pickUpsCollected["banana"] = 0;
        GameManager.Music().Stop();
        GameManager.MainMenu();
    }
}
