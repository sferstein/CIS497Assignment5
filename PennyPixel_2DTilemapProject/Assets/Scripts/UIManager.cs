using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
 * Sam Ferstein
 * Assignment 5
 * This manages the UI.
 */

public class UIManager : MonoBehaviour
{
    public int score = 0;
    public Text scoreText;
    public bool gameOver = false;
    // Start is called before the first frame update
    void Start()
    {
        //if (scoreText == null)
        //{
        //    scoreText = FindObjectOfType<Text>();
        //}
        scoreText.text = "Score: 0";
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameOver)
        {
            scoreText.text = "Score: " + score;
        }
        if (score >= 10)
        {
            gameOver = true;
            scoreText.text = "You Win!";
        }
    }
}
