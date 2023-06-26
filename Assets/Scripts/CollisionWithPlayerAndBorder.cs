using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionWithPlayerAndBorder : MonoBehaviour
{
    private GameObject player;
    public int score;
    
    private ScoreManager scoreManager;
    
    public int pointValue;
    public AudioClip soundeffect;
    public float volumeSoundeffect;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player") ;
        scoreManager = GameObject.Find("Score Text").GetComponent<ScoreManager>();
    }

    // Destroying it when touching tag: Border
    private void OnTriggerEnter2D(Collider2D collision)
    {
       // // in the level 2 = obstacles/target bouncing inside the game scene
       // if (gameObject.name == "Lv2_Obstacle")
       // {
            if(collision.tag == "Border" )
            {
                Destroy(this.gameObject);
            }

            else if(collision.tag == "Player")
            {
                if(gameObject.CompareTag("Obstacle"))
                {
                    Destroy(player.gameObject);
                    AudioSource.PlayClipAtPoint(soundeffect, transform.position, volumeSoundeffect);
                }
                else
                {
                    Destroy(this.gameObject);
                    scoreManager.UpdateScore(pointValue);
                    AudioSource.PlayClipAtPoint(soundeffect, transform.position, volumeSoundeffect);
                }
            }
       /*  }
        else 
        {
             if(collision.tag == "Border" || collision.tag == "TopBorder" || collision.tag ==  "BottomBorder")
            {
                Destroy(this.gameObject);
            }

            else if(collision.tag == "Player")
            {
                if(gameObject.CompareTag("Obstacle"))
                {
                    Destroy(player.gameObject);
                    AudioSource.PlayClipAtPoint(soundeffect, transform.position, volumeSoundeffect);
                }
                else
                {
                    Destroy(this.gameObject);
                    scoreManager.UpdateScore(pointValue);
                    AudioSource.PlayClipAtPoint(soundeffect, transform.position, volumeSoundeffect);
                }
            }
        } */
    }   
}