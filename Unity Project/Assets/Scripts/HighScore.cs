using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    // Een openbare statische Text-variabele om toegang te krijgen tot het tekstveld voor de highscore vanuit andere scripts.
    public static Text Highscore;

    // Deze methode wordt uitgevoerd bij de start van het script.
    void Start()
    {
        // Haal een referentie naar het Text-component op dat aan dit game-object is bevestigd.
        Highscore = GetComponent<Text>();

        // Stel de tekst van het Text-component in op "High Score: " gevolgd door de highscore die is opgeslagen in PlayerPrefs.
        Highscore.text = "High Score: " + PlayerPrefs.GetInt("HighScore").ToString();

        // Controleer of de huidige score (ItemCollection.Bananas) hoger is dan de opgeslagen highscore.
        if (ItemCollection.Bananas > PlayerPrefs.GetInt("HighScore"))
        {
            // Als de huidige score hoger is, update dan de highscore in PlayerPrefs.
            PlayerPrefs.SetInt("HighScore", ItemCollection.Bananas);

            // Pas de tekst van het Text-component aan om de nieuwe highscore weer te geven.
            Highscore.text = "High Score: " + ItemCollection.Bananas.ToString();
        }
    }
}
