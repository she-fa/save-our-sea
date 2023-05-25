using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawning : MonoBehaviour
{
    public GameObject obstacle;
    public GameObject target;

    // as an area range of spawning
    public float maxX;
    public float minX;
    public float maxY;
    public float minY;

    // delta time to generate the next obstacle
    public float timeBetweenSpawn;

    private float spawnTime;
    private float delayTimetoNextSpawn;

    // Update is called once per frame
    void Update()
    {
        if(Time.time >= spawnTime)
        {
            delayTimetoNextSpawn = Random.Range(3, 8);
            SpawnObstacle();
            Invoke("SpawnTarget",  delayTimetoNextSpawn);
            spawnTime = Time.time + timeBetweenSpawn;
        }
        
    }

    private void SpawnObstacle()
    {
        // Randomize the spawning area
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);

        // Instantiating the obstacle
        Instantiate(obstacle, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
    }

    private void SpawnTarget()
    {
        // Randomize the spawning area
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);

        // Instantiating the target
        Instantiate(target, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
    }
}
