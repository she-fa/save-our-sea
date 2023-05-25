using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Description:
// Score system is based on the time the player sustains in the game
public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    private float score;

    // Update is called once per frame
    void Update()
    {
        // Adding score when player is alive
        if(GameObject.FindGameObjectWithTag("Player") != null)
        {
            //score += 1 * Time.deltaTime;
            
            if(collision.gameObject.CompareTag("Target"))
            {
                score += 1;
                scoreText.text = ((int)score).ToString();
            }
        }
    }
}
