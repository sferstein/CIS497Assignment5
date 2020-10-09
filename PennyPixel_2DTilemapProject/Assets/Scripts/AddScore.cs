using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
 * Sam Ferstein
 * Assignment 5
 * This adds the score when the player collects a coin.
 */

public class AddScore : MonoBehaviour
{
    private UIManager uIManager;

    // Start is called before the first frame update
    void Start()
    {
        uIManager = GameObject.FindObjectOfType<UIManager>();
    }

    void OnTriggerEnter2D(Collider2D theCollider)
    {
        if (theCollider.CompareTag("Player"))
        {
            uIManager.score++;
        }
    }
}
