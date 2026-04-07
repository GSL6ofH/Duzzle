using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
    public float speed = 5f; //this decides how hard something can go
    public float jumpForce = 7f;

    //here we put in the keys for unity inspector
    // also because we use this we can decide the input in unity itself
    public KeyCode left;
    public KeyCode right;
    public KeyCode up;

    private Rigidbody2D rb;
    private bool _standOnGround;
    private bool _standOnPlayer;

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
            //if you dont do the correct input it wont move
            rb.linearVelocity = new Vector2(0, rb.linearVelocity.y);
        }

        //if you  press a key and you stand on the ground or a player you can jump
        if (Input.GetKeyDown(up) && (_standOnGround || _standOnPlayer))
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
            _standOnGround= false;
            _standOnPlayer = false;
        }

        if (Input.GetKeyDown(KeyCode.P))//restart button
        {
            SceneManager.LoadScene("Menu");
        }
    }

    //ground check
    //player check
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            _standOnGround = true;
        }
        else if (collision.gameObject.CompareTag("Player1"))
        {
            _standOnPlayer = true;
        }
        else if (collision.gameObject.CompareTag("Player2"))
        {
            _standOnPlayer= true;
        }
    }
}