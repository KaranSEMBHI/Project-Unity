using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Dit attribuut [SerializeField] maakt een privévariabele zichtbaar in de Unity Inspector voor bewerking.
    [SerializeField] private Transform playerTransform;

    // De Update-methode wordt bijgewerkt in elke frame.
    private void Update()
    {
        // Pas de positie van de camera aan op basis van de positie van de speler, maar behoud dezelfde Z-coördinaat (diepte).
        transform.position = new Vector3(playerTransform.position.x, playerTransform.position.y, transform.position.z);
    }
}
