using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMovement : MonoBehaviour
{
    public float accelerationTime = 2f;
    public float maxSpeed = 5f;
    private Vector2 movement;
    private float timeLeft;
    
    public Rigidbody2D rb;
    public float speed = 1;

	// For initialisation
    void Start () 
    {
		rb = GetComponent<Rigidbody2D> ();
	}
    
    void Update()
    {
        timeLeft -= Time.deltaTime;
        if(timeLeft <= 0)
        {
            movement = new Vector2(Random.Range(-1f, 0), Random.Range(-1f, 1f)); //new movement
            timeLeft += accelerationTime;
        }
    }

    void FixedUpdate()
    {
        rb.AddForce(movement * maxSpeed); // adding force with new movement
    }
}
