using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreScene : MonoBehaviour
{
    // Een referentie naar een tekstveld om de eindscore weer te geven.
    Text eindScore;

    // Dit is een methode die wordt opgeroepen wanneer de speler op de knop "Play" klikt.
    public void PlayGame()
    {
        // SceneManager.LoadSceneAsync(0) laadt een nieuwe scène met een index van 0.
        // Dit wordt meestal gebruikt om naar het hoofdmenu of het beginniveau van het spel terug te keren.
        SceneManager.LoadSceneAsync(0);
    }

    // Deze methode wordt uitgevoerd bij de start van de scène.
    private void Start()
    {
        // Koppel de referentie aan het tekstveld in de Unity Inspector.
        eindScore = GetComponent<Text>();

        // Stel de tekst van het tekstveld in om de eindscore weer te geven, die wordt opgeslagen in de ItemCollection.Bananas-variabele.
        eindScore.text = "Bananas: " + ItemCollection.Bananas;
    }
}
