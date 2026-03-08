using JetBrains.Annotations;
using UnityEngine;
using TMPro;

public class CoinCollect : MonoBehaviour
{
    public TextMeshProUGUI coinText;
    public static int totalCoins = 0;
    void Start()
    {
        coinText.text = "Coins: " + totalCoins;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            totalCoins++;
            coinText.text = "Coins: " + totalCoins;
            Destroy(gameObject);
        }
    }
}
