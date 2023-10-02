using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Void : MonoBehaviour
{
    // Deze methode wordt aangeroepen wanneer een 2D-collision plaatsvindt.
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Controleer of het game-object waarmee is gebotst de tag "Void" heeft.
        if (collision.gameObject.CompareTag("Void"))
        {
            // Als de speler in aanraking komt met de "Void", laad dan asynchroon (niet-blokkerend) een andere scène met index 2.
            SceneManager.LoadSceneAsync(2);
        }
    }
}
