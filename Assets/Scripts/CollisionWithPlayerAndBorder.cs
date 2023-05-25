using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionWithPlayerAndBorder : MonoBehaviour
{
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player") ;
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
            }
        }
    }
   
}
