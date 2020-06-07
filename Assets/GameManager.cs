using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static int currentDifficulty = 0;
    
    public static void PlayGame(int difficulty = 0)
    {
        currentDifficulty = difficulty;
        SceneManager.LoadScene(1);
    }
}
