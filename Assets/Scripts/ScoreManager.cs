using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


// Description:
// Score system is based on the time the player sustains in the game
public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private int score;
    public int scoreToWin = 10;
    public string nextLevelName = "Level1";
    public GameObject NextLevelButton;

 
    void Start()
    {
        score = 0;
        UpdateScore(0); //not updating any score in the start of the game
    }
    
    void Update()
    {
        if (score> scoreToWin)
        {
            // Deactivate the script on another GameObject named "OtherGameObject"
            GameObject otherObject = GameObject.Find("GameManager");
            otherObject.GetComponent<GameOver>().enabled = false;
            NextLevelButton.SetActive(true);
        }
    }
   
    // Next Level buttons
    public void NextLevel()
    {     
        // Load the next level
        SceneManager.LoadScene(nextLevelName);
    }

    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score: " + score;  
    }
    
}
