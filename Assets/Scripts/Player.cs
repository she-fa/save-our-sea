using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float playerSpeed;
    private Rigidbody2D rb; // Applying physics on player
    private Vector2 playerDirection; // Process Player's input

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // Fetching rb from player
    }

    // Update is called once per frame
    // ^-- updating regularly
    void Update()
    {
        // Detecting which key pressed by the user
        float directionY = Input.GetAxisRaw("Vertical"); 
        playerDirection = new Vector2(0, directionY).normalized;
    }

    // Updated is called once per physics frame
    // ^-- anything to be applied to Rigidbody
    void FixedUpdate()
    {
        rb.velocity = new Vector2(0, playerDirection.y * playerSpeed);
    }
}
