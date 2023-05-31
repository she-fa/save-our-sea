using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionWithPlayerAndBorder : MonoBehaviour
{
    private GameObject player;
    // public float score;
    public int score;
    private ScoreManager scoreManager;
    
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player") ;
        scoreManager = GameObject.Find("Score Text").GetComponent<ScoreManager>();
    }

    // Destroying it when touching tag: Border
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Border")
        {
            Destroy(this.gameObject);
        }

        else if(collision.tag == "Player")
        {
            if(gameObject.CompareTag("Obstacle"))
            {
                Destroy(player.gameObject);
            }
            else
            {
                Destroy(this.gameObject);
                scoreManager.UpdateScore(5);
                //Debug.Log(this.gameObject.name + "is destroyed");
                //score += 1;
               // Debug.Log("is the score increased?" + scoreText.text);
            }
        }
    }
   
}
