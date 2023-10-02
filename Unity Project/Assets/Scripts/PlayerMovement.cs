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

    private enum MovementState
    {
        idle,       // Staat stil
        running,    // Aan het rennen
        jumping,    // Springt
        falling     // Valt
    }

    // Variabele om te controleren of de speler de grond raakt
    private bool raaktDeGrond;

    // Variabele voor de horizontale input van de speler
    private float horizontaleInput = 0f;

    private bool hasJumped = false; // Voeg deze variabele toe om bij te houden of de speler heeft gesprongen

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

        // Springen als de spatiebalk wordt ingedrukt, de speler op de grond staat, en nog niet heeft gesprongen
        if (raaktDeGrond)
        {
            hasJumped = false; // Reset de vlag naar false wanneer de speler de grond raakt
        }

        if (raaktDeGrond && Input.GetKeyDown(KeyCode.Space) && !hasJumped)
        {
            rb.AddForce(Vector2.up * sprongKracht, ForceMode2D.Impulse);
            hasJumped = true; // Zet de vlag naar true na het springen
        }

        UpdateAnimationState();
    }

    private void UpdateAnimationState()
    {
        MovementState state;
        if (horizontaleInput > 0f)
        {
            state = MovementState.running;
            sprite.flipX = false;
        }
        else if (horizontaleInput < 0f)
        {
            state = MovementState.running;
            sprite.flipX = true;
        }
        else
        {
            state = MovementState.idle;
        }

        if (rb.velocity.y > .1f)
        {
            state = MovementState.jumping;
        }
        else if (rb.velocity.y < -.1f)
        {
            state = MovementState.falling;
        }
        anim.SetInteger("state", (int)state);
    }
}
