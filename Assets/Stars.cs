using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stars : MonoBehaviour
{
 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "LeftBorder")
        {
            Destroy(gameObject);
        }
        else if (collision.gameObject.name == "Player")
        {
            Score.score += 2;
            Destroy(gameObject); 
        }
    }
}
