using JetBrains.Annotations;
using System.Collections;
using UnityEngine;

public class CoinCollect : MonoBehaviour
{    
    public static int totalCoins = 0;

    [Header("Audio")]
    public AudioClip coinSound;
    private AudioSource audioSource;

    [Header("VFX")]
    public float flashDuration = 0.1f;
    private SpriteRenderer spriteRenderer;
    private ParticleSystem coinParticle;
    public static event System.Action<int> OnCoinCollected;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        coinParticle = GetComponentInChildren<ParticleSystem>();
    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))  // ← KONTROL GERİ GELDİ!
        {
            PlayCoinParticle();
            
            AudioSource playerAudio = other.GetComponent<AudioSource>();
            if (playerAudio != null && coinSound != null)
            {
                playerAudio.PlayOneShot(coinSound);
            }
            
            totalCoins++;
            OnCoinCollected?.Invoke(totalCoins);

            Destroy(gameObject, 0.3f);
        }
    }
    private void PlayCoinParticle()
    {
        if (coinParticle != null)
        {
            coinParticle.Play();
        }    
    }
}