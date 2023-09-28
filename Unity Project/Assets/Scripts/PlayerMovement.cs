using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Variabelen voor snelheid en sprongkracht
    public float snelheid = 5f;
    public float sprongKracht = 10f;

    // Referentie naar de Rigidbody2D-component van de speler
    private Rigidbody2D rb;
    private SpriteRenderer sprite;
    private Animator anim;  

    // Variabele om te controleren of de speler de grond raakt
    private bool raaktDeGrond;

    // Variabele voor de horizontale input van de speler
    private float horizontaleInput = 0f;

    void Start()
    {
        // Haal de Rigidbody2D-component op bij de speler
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        // Controleer of de speler de grond raakt
        raaktDeGrond = Physics2D.Raycast(transform.position, Vector2.down, 0.1f);

        // Horizontale beweging
        horizontaleInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(horizontaleInput * snelheid, rb.velocity.y);

        // Springen als de spatiebalk wordt ingedrukt en de speler op de grond staat
        if (raaktDeGrond && Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * sprongKracht, ForceMode2D.Impulse);
        }

        UpdateAnimationState();
    }
    private void UpdateAnimationState()
    {

        if (horizontaleInput > 0f)
        {
            anim.SetBool("running", true);
            sprite.flipX = false;
        }
        else if (horizontaleInput < 0f)
        {
            anim.SetBool("running", true);
            sprite.flipX = true;
        }
        else
        {
            anim.SetBool("running", false);
        }
    }
}
