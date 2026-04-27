using UnityEngine;
using UnityEngine.InputSystem;

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

    private PlayerControls controls;
    private Vector2 moveInput;

    [Header("Audio")]
    public AudioClip jumpSound;
    private AudioSource audioSource;
    [Header("VFX")]
    public ParticleSystem jumpParticles;

    private bool mobileLeft = false;
    private bool mobileRight = false;

    void Awake()
    {
       controls = new PlayerControls();
    }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
        jumpParticles = GetComponentInChildren<ParticleSystem>();
    }

    void OnEnable()
    {
        controls.Enable();
    }
    
    void OnDisable()
    {
        controls.Disable();
    }

    void Update()
    {
        CheckGround();

        moveInput = controls.GamePlay.Move.ReadValue<Vector2>();

        if (controls.GamePlay.Jump.WasPressedThisFrame())
        {
            jumpBufferCounter = jumpBufferTime;
        }
        else if (jumpBufferCounter > 0)
        {
            jumpBufferCounter -= Time.deltaTime;
        }

        
        if (controls.GamePlay.Jump.WasReleasedThisFrame() && rb.linearVelocity.y > 0)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, rb.linearVelocity.y * jumpCutMultiplier);
        }
    }

   void FixedUpdate()
   {
       float horizontalInput = moveInput.x;

        if (mobileLeft) horizontalInput = -1f;
        if (mobileRight) horizontalInput = 1f;       

       float currentSpeed = isGrounded ? speed : speed * airControlMultiplier;
       rb.linearVelocity = new Vector2(horizontalInput * currentSpeed, rb.linearVelocity.y);

       if (isGrounded && jumpBufferCounter > 0)
       {
           rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
           jumpBufferCounter = 0f;

           if (audioSource != null && jumpSound != null)
            {
                audioSource.PlayOneShot(jumpSound);
            }
            if (jumpParticles != null)
            {
                jumpParticles.Play();
            }
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
        float checkWidth = 0.3f;
    
        RaycastHit2D hitCenter = Physics2D.Raycast(groundCheck.position, Vector2.down, groundCheckDistance, groundLayer);
        RaycastHit2D hitLeft = Physics2D.Raycast(groundCheck.position + Vector3.left * checkWidth, Vector2.down, groundCheckDistance, groundLayer);
        RaycastHit2D hitRight = Physics2D.Raycast(groundCheck.position + Vector3.right * checkWidth, Vector2.down, groundCheckDistance, groundLayer);
    
        isGrounded = hitCenter.collider != null || hitLeft.collider != null || hitRight.collider != null;
    
        Debug.DrawRay(groundCheck.position, Vector2.down * groundCheckDistance, isGrounded ? Color.green : Color.red);
        Debug.DrawRay(groundCheck.position + Vector3.left * checkWidth, Vector2.down * groundCheckDistance, Color.yellow);
        Debug.DrawRay(groundCheck.position + Vector3.right * checkWidth, Vector2.down * groundCheckDistance, Color.yellow);
    }

    public void SetMobileLeft(bool value)
    {
        mobileLeft = value;
    }
    
    public void SetMobileRight(bool value)
    {
        mobileRight = value;
    }

    public void SetMobileJump(bool value)
    {
        if (value)
        {
            jumpBufferCounter = jumpBufferTime;
        }
        else if (rb.linearVelocity.y > 0)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, rb.linearVelocity.y * jumpCutMultiplier);
        }
    }
}