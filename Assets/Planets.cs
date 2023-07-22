using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planets : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "LeftBorder")
        {
            Destroy(gameObject);
        }
        else if (collision.gameObject.name == "Player")
        {
            Score.score += 10;
            Destroy(gameObject);
        }
    }
}
