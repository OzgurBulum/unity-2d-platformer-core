using UnityEngine;
using TMPro;

public class HPUI : MonoBehaviour
{
    public TMP_Text hpText;

    void OnEnable()
    {
        PlayerHealth.OnHealthChanged += UpdateHPText;
        PlayerHealth.OnPlayerDied += HandleDeath;
    }

    void OnDisable()
    {
        PlayerHealth.OnHealthChanged -= UpdateHPText;
        PlayerHealth.OnPlayerDied -= HandleDeath;
    }

    void Start()
    {
        hpText.text = "HP: 3";
    }

    void UpdateHPText(int currentHealth)
    {
        hpText.text = "HP: " + currentHealth;
    }

    void HandleDeath()
    {
        hpText.text = "Dead!";
        hpText.color = Color.black;
    }

}
