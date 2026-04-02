using UnityEngine;

public class Movement : MonoBehaviour
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

        if (Input.GetKeyDown(up) && standOnGround)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
            standOnGround= false;
        }
    }

    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            standOnGround = true;
        }
        else if (collision.gameObject.CompareTag("Player1"))
        {
            standOnGround = true;
        }
        else if (collision.gameObject.CompareTag("Player2"))
        {
            standOnGround = true;
        }
    }
}