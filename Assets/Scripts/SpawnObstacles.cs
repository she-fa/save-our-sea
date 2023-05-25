using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacles : MonoBehaviour
{
    public GameObject obstacle;

    // as an area range of spawning
    public float maxX;
    public float minX;
    public float maxY;
    public float minY;

    // delta time to generate the next obstacle
    public float timeBetweenSpawn;

    private float spawnTime;

    // Update is called once per frame
    void Update()
    {
        if(Time.time >= spawnTime)
        {
            Spawn();
            spawnTime = Time.time + timeBetweenSpawn;
        }
        
    }

    void Spawn()
    {
        // Randomize the spawning area
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);

        // Instantiating the obstacle
        Instantiate(obstacle, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
    }
}
