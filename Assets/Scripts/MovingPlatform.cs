using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public Transform pointA;
    public Transform pointB;
    public float speed = 2f;

    private Transform target;
    private Rigidbody2D rb;
    private Vector2 lastPosition;
    private Rigidbody2D playerRb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        transform.position = pointA.position;
        target = pointB;
        lastPosition = rb.position;
    }

    void FixedUpdate()
    {
        Vector2 newPos = Vector2.MoveTowards(
            rb.position,
            target.position,
            speed * Time.fixedDeltaTime
        );

        Vector2 delta = newPos - rb.position;
        rb.MovePosition(newPos);

        if (playerRb != null)
        {
            playerRb.transform.position += (Vector3)delta;
        }

        if (Vector2.Distance(rb.position, target.position) < 0.05f)
        {
            target = (target == pointA) ? pointB : pointA;
        }

        lastPosition = rb.position;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            playerRb = collision.gameObject.GetComponent<Rigidbody2D>();
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            playerRb = null;
        }
    }
}