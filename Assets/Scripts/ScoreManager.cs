using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

// Description:
// Score system is based on the time the player sustains in the game
public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private int score;
 
    void Start()
    {
        score = 0;
        UpdateScore(0); //not updating any score in the start of the game
    }
    
    void Update()
    {

    }
   
    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score: " + score;  
    }
    
}
