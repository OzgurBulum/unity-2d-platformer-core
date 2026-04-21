using System.Collections;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 3;
    private int currentHealth;

    public static event System.Action<int> OnHealthChanged;
    public static event System.Action OnPlayerDied;
    [Header("Audio")]
    public AudioClip hitSound;
    private AudioSource audioSource;
    [Header("VFX")]
    public float flashDuration = 0.1f;
    private SpriteRenderer spriteRenderer;
    void Start()
    {
        currentHealth = maxHealth;
        OnHealthChanged?.Invoke(currentHealth);
        audioSource = GetComponent<AudioSource>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    public void TakeDamage(int Damage)
    {
        if (audioSource != null && hitSound != null)
        {
            audioSource.PlayOneShot(hitSound);
        }
        StartCoroutine(DamageFlash());

        currentHealth -= Damage;
        OnHealthChanged?.Invoke(currentHealth);
        Debug.Log("Player took damage! Current health: " + currentHealth);
        if (currentHealth <= 0)
        {
            Die();
        }
    }
    private void Die()
    {
        OnPlayerDied?.Invoke();
        Debug.Log("Player has died!");
        Destroy(gameObject);
    }

    private System.Collections.IEnumerator DamageFlash()
    {
        if (spriteRenderer != null)
        {
            Color originalColor = spriteRenderer.color;
            spriteRenderer.color = Color.red;
            yield return new WaitForSeconds(flashDuration);
            spriteRenderer.color = originalColor;
        }
    }
}
