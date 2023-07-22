using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawning : MonoBehaviour
{
    public GameObject obstacle;
    public GameObject star;
    public GameObject planet;
    public float starSpawnInterval;
    private float starSpawnTime = 0;
    public float planetSpawnInterval;
    private float planetSpawnTime = 0;

    public float spawnInterval;
    public float checkpoint;
    private float spawnTime = 0;

    public float minX;
    public float maxX;
    public float minY;
    public float maxY;

    void Start()
    {
        spawnInterval = 2.25f;
        planetSpawnInterval = 10f;
        starSpawnInterval = 1f; 
        checkpoint = 10;
        spawnTime = 0;
        starSpawnTime = 4;
        planetSpawnTime = 12;
    }

    // Update is called once per frame

    void Update()
    {
        var time = Time.timeSinceLevelLoad;
        if (time > spawnTime)
        {
            CreateObstacle();
            spawnTime = spawnInterval + time;

            if (spawnInterval <= 0.25f)
            {
                spawnInterval = 0.25f; 
            }
            else if (time >= checkpoint)
            {
                spawnInterval -= 0.25f;
                checkpoint += 10; 
            }
        }
        if (time > starSpawnTime)
        {
            CreateStar();
            starSpawnTime = starSpawnInterval + time;
        }
        if (time > planetSpawnTime)
        {
            CreatePlanet();
            planetSpawnTime = planetSpawnInterval + time;
        }
    }

    public void CreateObstacle()
    {
        float xSpot = Random.Range(minX, maxX);
        float ySpot = Random.Range(minY, maxY);

        var newPos = new Vector3(xSpot, ySpot, 0) + transform.position;

        Instantiate(obstacle, newPos, transform.rotation);
    }

    public void CreateStar()
    {

        float xSpot = Random.Range(minX, maxX);
        float ySpot = Random.Range(minY, maxY);

        var newPos = new Vector3(xSpot, ySpot, 0) + transform.position;

        Instantiate(star, newPos, star.transform.rotation);
    }

    public void CreatePlanet()
    {

        float xSpot = Random.Range(minX, maxX);
        float ySpot = Random.Range(minY, maxY);

        var newPos = new Vector3(xSpot, ySpot, 0) + transform.position;

        Instantiate(planet, newPos, planet.transform.rotation);
    }

}
