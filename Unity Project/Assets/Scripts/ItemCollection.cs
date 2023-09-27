using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollection : MonoBehaviour
{
    // Deze methode wordt automatisch aangeroepen wanneer het GameObject waarop dit script is bevestigd
    // een trigger-collider raakt van een ander GameObject.
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Controleer of het andere GameObject dat de trigger raakte is getagd als "Apple".
        if (collision.gameObject.CompareTag("Apple"))
        {
            // Als het raakte object is getagd als "Apple", vernietig het huidige GameObject.
            // Het huidige GameObject is het object waarop dit script is bevestigd.
            Destroy(gameObject);
        }
    }
}

