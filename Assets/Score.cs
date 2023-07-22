using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System; 

public class Score : MonoBehaviour
{
    public static float score;  // everyone has the same score
    public static Text scoreText; // everyone has the same text
    AudioSource scoreSound;
    public static float checkpoint; 

    // Use this for initialization
    internal void Start()
    {
        scoreText = GetComponent<Text>();
        UpdateText();
        score = 0; 
        scoreSound = GetComponent<AudioSource>();
        checkpoint = 50; 
    }

    void Update()
    {
        if (GameObject.Find("Player") != null)
        {
            score += Time.deltaTime * 1;
            UpdateText();
        }
        if ((int)score >= 10 && (int)score >= checkpoint)
        {
            scoreSound.Play();
            scoreText.color = Color.green;
            checkpoint += 50; 
        }
    }

    public static void UpdateText()
    {
        if ((int)score >= 6 && (checkpoint - (int)score) >= 45)
        {
            scoreText.color = Color.green;
        }
        else
        {
            scoreText.color = Color.white;
        }
        scoreText.text = String.Format("Score: {0}", (int) score);
        
    }
}
