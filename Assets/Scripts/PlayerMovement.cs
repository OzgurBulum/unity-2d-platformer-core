using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private float airControlMultiplier = 0.3f;
    [SerializeField] private float jumpForce = 5f;
    [SerializeField] private float jumpCutMultiplier = 0.5f;
    [SerializeField] private float fallMultiplier = 2.5f;
    [SerializeField] private float jumpBufferTime = 0.1f;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private float groundCheckDistance = 0.2f;

    private Rigidbody2D rb;
    private float jumpBufferCounter = 0f;
    private bool isGrounded = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        CheckGround();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            jumpBufferCounter = jumpBufferTime;
        }
        else if (jumpBufferCounter > 0)
        {
            jumpBufferCounter -= Time.deltaTime;
        }

        if (Input.GetKeyUp(KeyCode.Space) && rb.linearVelocity.y > 0)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, rb.linearVelocity.y * jumpCutMultiplier);
        }
    }

   void FixedUpdate()
   {
       float horizontalInput = 0f;

       if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
       {
           horizontalInput = 1f;
       }

       if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
       {
           horizontalInput = -1f;
       }

       float currentSpeed = isGrounded ? speed : speed * airControlMultiplier;
       rb.linearVelocity = new Vector2(horizontalInput * currentSpeed, rb.linearVelocity.y);

       if (isGrounded && jumpBufferCounter > 0)
       {
           rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
           jumpBufferCounter = 0f;
       }

       if (rb.linearVelocity.y < 0)
       {
           rb.gravityScale = fallMultiplier;
       }
       else if (rb.linearVelocity.y > 0)
       {
           rb.gravityScale = 1f;
       }
   }

    void CheckGround()
    {
        RaycastHit2D hit = Physics2D.Raycast(groundCheck.position, Vector2.down, groundCheckDistance, groundLayer);
        isGrounded = hit.collider != null;
        Debug.DrawRay(groundCheck.position, Vector2.down * groundCheckDistance, isGrounded ? Color.green : Color.red);
    }
}