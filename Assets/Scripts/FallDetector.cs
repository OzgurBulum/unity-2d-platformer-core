using UnityEngine;

public class FallDetector : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerHealth playerHealth = other.GetComponent<PlayerHealth>();
            if (playerHealth != null)
            {
                Vector3 spawnPos = CheckpointManager.Instance.GetSpawnPosition();   
                other.transform.position = spawnPos;
                playerHealth.TakeDamage(1);
            }
        }
    }
}