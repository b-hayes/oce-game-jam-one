using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static int currentDifficulty = 0;
    public static Dictionary<string, int> pickUpsCollected = new Dictionary<string, int>();

    public static void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
    
    public static void PlayGame(int difficulty = 0)
    {
        currentDifficulty = difficulty;
        SceneManager.LoadScene(1);
    }

    public static void QuitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }

    public static void Lose()
    {
        SceneManager.LoadScene(3);
    }
    
    public static void Win()
    {
        SceneManager.LoadScene(2);
    }

    public static AudioSource Music()
    {
        return GameObject.FindGameObjectWithTag("GameManager").GetComponent<AudioSource>();
    }
}
