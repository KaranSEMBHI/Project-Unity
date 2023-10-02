using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollection : MonoBehaviour
{
    // Een openbare statische integer die de score voor verzamelde bananen bijhoudt.
    public static int Bananas = 0;

    // Een privé Text-variabele om toegang te krijgen tot een tekstveld om de score weer te geven.
    [SerializeField] private Text BananasText;

    // Deze methode wordt aangeroepen wanneer een ander collider-object de collider van dit object binnengaat.
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Controleer of het binnenkomende object de tag "Banana" heeft.
        if (other.gameObject.CompareTag("Banana"))
        {
            // Vernietig het binnenkomende object (de banaan).
            Destroy(other.gameObject);

            // Verhoog de score voor verzamelde bananen met één.
            Bananas++;

            // Pas de tekst van het Text-component aan om de bijgewerkte score weer te geven.
            BananasText.text = "Bananas: " + Bananas;
        }
    }
}
