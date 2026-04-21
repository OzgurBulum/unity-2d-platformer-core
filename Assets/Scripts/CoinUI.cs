using UnityEngine;
using TMPro;

public class CoinUI : MonoBehaviour
{
    public TextMeshProUGUI coinText;
    void OnEnable()
    {
        CoinCollect.OnCoinCollected += UpdateCoinText;
    }

    void OnDisable()
    {
        CoinCollect.OnCoinCollected -= UpdateCoinText;
    }

    void Start()
    {
        coinText.text = "Coins: ";
    }

    void UpdateCoinText(int totalCoins)
    {
        coinText.text = "Coins: " + totalCoins;
    }
}
