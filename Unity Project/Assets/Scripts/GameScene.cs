using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameScene : MonoBehaviour
{
    // Deze methode wordt automatisch aangeroepen wanneer er een 2D-collision plaatsvindt.
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Controleer of het game-object waarmee is gebotst de tag "Trophee" heeft.
        if (collision.gameObject.CompareTag("Trophee"))
        {
            // Laad asynchroon (niet-blokkerend) een andere scène met index 2.
            SceneManager.LoadSceneAsync(2);
        }
    }
}
