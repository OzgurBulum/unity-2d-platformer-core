using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

public class EnemyPatrol : MonoBehaviour
{
    public Transform leftPoint;
    public Transform rightPoint;
    public float speed = 2f;

    private bool movingRight = true;

    void Update()
    {
        if(movingRight)
        {
            transform.position = Vector2.MoveTowards(transform.position,rightPoint.position, speed * Time.deltaTime);
            if(Vector2.Distance(transform.position, rightPoint.position) < 0.1f)
            {
                movingRight = false;
            }
        }
        else
        {
            transform.position = Vector2.MoveTowards(transform.position, leftPoint.position, speed * Time.deltaTime);
            if (Vector2.Distance(transform.position, leftPoint.position) < 0.1f)
            {
                movingRight = true;
            }
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            float playerY = collision.gameObject.transform.position.y;
            float enemyY = transform.position.y;

            if (playerY > enemyY + 0.5f)
            {
                Debug.Log("Enemy stomped!");
                Destroy(gameObject);
            }
            else
            {
                Debug.Log("Player hit from side!");

                PlayerHealth playerHealth = collision.gameObject.GetComponent<PlayerHealth>();
                if (playerHealth != null)
                {
                    playerHealth.TakeDamage(1);
                }
            }
        }
    }
}