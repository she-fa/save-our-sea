using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionWithPlayerAndBorder : MonoBehaviour
{
    private GameObject player;
    public int score;
    
    private ScoreManager scoreManager;
    private AudioManager audioManager;
    
    public int pointValue;
    public AudioClip soundeffect;

    
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player") ;
        scoreManager = GameObject.Find("Score Text").GetComponent<ScoreManager>();
        audioManager = GameObject.Find("GameManager").GetComponent<AudioManager>();
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
                audioManager.PlayOneShot(soundeffect);
                Debug.Log("The soundeffect of obstacle is played");
                //AudioSource.PlayClipAtPoint(soundeffect, this.gameObject.transform.position);


            }
            else
            {
                Destroy(this.gameObject);
                scoreManager.UpdateScore(pointValue);
                audioManager.PlayOneShot(soundeffect);
                Debug.Log("The soundeffect of target is played");

                //AudioSource.PlayClipAtPoint(soundeffect, this.gameObject.transform.position);
            }
        }
    }
   
}
