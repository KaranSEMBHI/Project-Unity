using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class IntroScene : MonoBehaviour
{
    // Dit is een methode die wordt opgeroepen wanneer de speler op de knop "Play" klikt.
    public void PlayGame()
    {
        // SceneManager.LoadSceneAsync(1) laadt een nieuwe scene met een index van 1.
        // Dit wordt meestal gebruikt om naar een andere game- of niveauscene te gaan.
        SceneManager.LoadSceneAsync(1);
    }

}

