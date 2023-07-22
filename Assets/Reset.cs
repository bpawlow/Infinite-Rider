using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour
{
    public GameObject endGame;

    void Start()
    {
        endGame.SetActive(false);
    }

    public void ResetGame()
    {
        SceneManager.LoadScene("MainGame");
    }


    void Update()
    {
        if (GameObject.Find("Player") == null)
        {
            endGame.SetActive(true);
        }
    }

}
