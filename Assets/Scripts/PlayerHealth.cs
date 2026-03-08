using UnityEngine;
using TMPro;

public class PlayerHealth : MonoBehaviour
{
    public TextMeshProUGUI hpText;
    public int maxHealth = 3;
    private int currentHealth;

    void Start()
    {
        currentHealth = maxHealth;
        hpText.text = "HP: " + currentHealth;
    }
    public void TakeDamage(int Damage)
    {
        currentHealth -= Damage;
        hpText.text = "HP: " + currentHealth;
        Debug.Log("Player took damage! Current health: " + currentHealth);
        if (currentHealth <= 0)
        {
            Die();
        }
    }
    private void Die()
    {
        hpText.text = "Dead!";
        hpText.color = Color.black;
        Debug.Log("Player has died!");
        Destroy(gameObject);
    }
}
