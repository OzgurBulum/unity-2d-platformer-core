using UnityEngine;

public class HazardDamage : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision) 
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player hit a hazard!");

            PlayerHealth playerHealth = collision.gameObject.GetComponent<PlayerHealth>();
            
            if (playerHealth != null)
            {
                playerHealth.TakeDamage(1);
            }
        }   
    }
}
