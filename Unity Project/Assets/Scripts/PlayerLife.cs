using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    private Rigidbody2D rb;  // Een privévariabele om toegang te krijgen tot het Rigidbody2D-component van de speler.
    private Animator animator;  // Een privévariabele om toegang te krijgen tot de Animator-component van de speler.

    private void Start()
    {
        // Bij het starten van het spel, krijg toegang tot het Rigidbody2D-component en de Animator-component van de speler.
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Controleer of de speler botst met een game-object dat de tag "Trap" heeft.
        if (collision.gameObject.CompareTag("Trap"))
        {
            // Als de speler een valkuil raakt, roep de "Die" methode aan om de spelerstatus te beheren.
            Die();
        }
    }

    private void Die()
    {
        // Schakel de Rigidbody2D-component van de speler uit om beweging te voorkomen.
        rb.bodyType = RigidbodyType2D.Static;

        // Activeer een "death"-trigger in de Animator-component om een doodanimatie af te spelen.
        animator.SetTrigger("death");
    }

    private void RestartLevel()
    {
        // Laad asynchroon (niet-blokkerend) de huidige scène opnieuw om het niveau opnieuw te starten.
        SceneManager.LoadSceneAsync(2);
    }
}
