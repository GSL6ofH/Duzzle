using UnityEngine;

public class SpelerBeweging : MonoBehaviour
{
    public float speed = 5f;
    public float jumpForce = 7f;

    // Hier stellen we de toetsen in via de Unity Inspector
    public KeyCode left;
    public KeyCode right;
    public KeyCode up;

    private Rigidbody2D rb;
    private bool standOnGround;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Horizontale beweging
        if (Input.GetKey(left))
        {
            rb.linearVelocity = new Vector2(-speed, rb.linearVelocity.y);
        }
        else if (Input.GetKey(right))
        {
            rb.linearVelocity = new Vector2(speed, rb.linearVelocity.y);
        }
        else
        {
            rb.linearVelocity = new Vector2(0, rb.linearVelocity.y);
        }

        // Springen
        if (Input.GetKeyDown(up) && standOnGround)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
            standOnGround= false;
        }
    }

    // Check of de speler de grond raakt (simpele methode)
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            standOnGround = true;
        }
    }
}