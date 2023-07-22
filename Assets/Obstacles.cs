using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{

    private GameObject spaceship; 

    void Start()
    {
        spaceship = GameObject.Find("Player");
    }

    void OnMouseDown()
    {
        Destroy(gameObject);
        Score.score -= 20;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "LeftBorder")
        {
            Destroy(gameObject);
        }
        else if (collision.gameObject.name == "Player")
        {
            Destroy(spaceship.gameObject);
        }
        //else if (collision.gameObject.name == "Bullet")
        //{
        //    Destroy(gameObject);
        //    Score.score -= 20;
        //}
    }
}
