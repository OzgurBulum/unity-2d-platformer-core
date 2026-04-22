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
    public float invincibleDuration = 1f; // ← hasar sonrası bekleme süresi
    private SpriteRenderer spriteRenderer;
    private bool isInvincible = false; // ← bu eklendi

    void Start()
    {
        currentHealth = maxHealth;
        OnHealthChanged?.Invoke(currentHealth);
        audioSource = GetComponent<AudioSource>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void TakeDamage(int damage)
    {
        if (isInvincible) return; // ← spam engeli burada

        if (audioSource != null && hitSound != null)
            audioSource.PlayOneShot(hitSound);

        currentHealth -= damage;
        OnHealthChanged?.Invoke(currentHealth);

        if (currentHealth <= 0)
        {
            Die();
        }
        else
        {
            StartCoroutine(DamageFlash());
        }
    }

    private void Die()
    {
        OnPlayerDied?.Invoke();
        Destroy(gameObject);
    }

    private IEnumerator DamageFlash()
    {
        isInvincible = true;

        spriteRenderer.color = Color.red;
        yield return new WaitForSeconds(flashDuration);
        spriteRenderer.color = Color.white;

        yield return new WaitForSeconds(invincibleDuration - flashDuration);

        isInvincible = false;
    }
}