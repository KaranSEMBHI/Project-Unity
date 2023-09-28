using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollection : MonoBehaviour
{
    private int bananas = 0;    
    // Deze methode wordt automatisch aangeroepen wanneer het GameObject waarop dit script is bevestigd
    // een trigger-collider raakt van een ander GameObject.
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Controleer of het andere GameObject dat de trigger raakte is getagd als "Apple".
        if (collision.gameObject.CompareTag("Banana"))
        {
            // Als het raakte object is getagd als "Banana", vernietig het huidige GameObject.
            // Het huidige GameObject is het object waarop dit script is bevestigd.
            Destroy(collision.gameObject);
            bananas++;
            Debug.Log("Bananas: " + bananas);


        }
    }
}

