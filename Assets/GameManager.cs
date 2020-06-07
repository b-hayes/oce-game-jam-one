using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static int currentDifficulty = 0;
    
    public static void PlayGame(int difficulty = 0)
    {
        print("Play button pressed");
        currentDifficulty = difficulty;
        // SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
