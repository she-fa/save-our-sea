using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

public class LevelManager : MonoBehaviour
{
    public int scoreToWin = 100;
    public string nextLevelName = "Level1";
    //public KeyCode nextLevelKey = KeyCode.Space;

    private int currentScore = 0;
    private bool hasWon = false;

    public GameObject NextLevelButton;

    // Call this method whenever the player's score increases
    public void IncreaseScore(int amount)
    {
        if (hasWon) return; // Player has already won, ignore further score increases

        currentScore += amount;
        if (currentScore >= scoreToWin)
        {
            hasWon = true;
            //Debug.Log("Player wins!");

            // Enable the ability to move to the next level
            //Debug.Log("Press " + nextLevelKey.ToString() + " to move to the next level.");
        }
    }

    // Next Level buttons
    public void NextLevel()
    {
        // Load the next level
        SceneManager.LoadScene(nextLevelName);
    }

    void Update()
    {
        if (hasWon)
        {
            //LoadNextLevel();
            NextLevelButton.SetActive(true);
            
        }
    }

}