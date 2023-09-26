using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Variabelen voor snelheid en sprongkracht
    public float snelheid = 5f;
    public float sprongKracht = 10f;

    // Referentie naar de Rigidbody2D-component van de speler
    private Rigidbody2D rb;

    // Variabele om te controleren of de speler de grond raakt
    private bool raaktDeGrond;

    void Start()
    {
        // Haal de Rigidbody2D-component op bij de speler
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Controleer of de speler de grond raakt
        raaktDeGrond = Physics2D.Raycast(transform.position, Vector2.down, 0.1f);

        // Horizontale beweging
        float horizontaleInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(horizontaleInput * snelheid, rb.velocity.y);

        // Springen als de spatiebalk wordt ingedrukt en de speler op de grond staat
        if (raaktDeGrond && Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * sprongKracht, ForceMode2D.Impulse);
        }
    }
}
