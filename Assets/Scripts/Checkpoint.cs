using UnityEngine;
using System.Collections;

public class Checkpoint : MonoBehaviour
{
    private bool isActivated = false;
    private SpriteRenderer spriteRenderer;
    private Color originalColor;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        if (spriteRenderer != null)
            originalColor = spriteRenderer.color;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !isActivated)
        {
            isActivated = true;
            CheckpointManager.Instance.SetCheckpoint(transform);
            StartCoroutine(FlashCheckpoint());
        }
    }

    private IEnumerator FlashCheckpoint()
    {
        if (spriteRenderer != null)
        {
            spriteRenderer.color = Color.yellow;
            yield return new WaitForSeconds(0.3f);
            spriteRenderer.color = originalColor;
        }
    }
}