using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    //vector direction of spaceship player
    public Vector2 spaceshipDir;
    
    // Rigid body component of player 
    public Rigidbody2D rbSpaceship;

    // speed of spaceship player 
    public float spaceshipSpeed;

    ////bullet prefab
    //public GameObject bullet;

    ////Speed of bullet 
    //public float speed = 100f;

    // Start is called before the first frame update
    void Start()
    {
        rbSpaceship = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        spaceshipDir = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized; 
        //if (Input.GetKeyDown("space"))
        //{
        //    var bulletObject = Instantiate(bullet, transform.position, Quaternion.identity);
        //    bulletObject.transform.position = transform.position;
        //    bulletObject.GetComponent<Rigidbody2D>().velocity = transform.right * speed;
        //}
    }

    void FixedUpdate()
    {
        rbSpaceship.velocity = new Vector2((spaceshipSpeed / 2) * spaceshipDir.x, spaceshipSpeed * spaceshipDir.y);
    }
}

