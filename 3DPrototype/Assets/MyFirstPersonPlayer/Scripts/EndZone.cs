using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/* 
 * Sam Ferstein
 * Assignment 5
 * This causes the game to end.
 */

public class EndZone : MonoBehaviour
{
    public Text textbox;

    private void Start()
    {
        textbox.text = "";
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            textbox.text = "You Win!";
        }
    }
}
