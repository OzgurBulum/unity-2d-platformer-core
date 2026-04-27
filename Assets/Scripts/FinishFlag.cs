using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class FinishFlag : MonoBehaviour
{
    public int totalCoinsInLevel;
    public GameObject finishPanel;
    public TextMeshProUGUI warningText;
    public TextMeshProUGUI coinResultText;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (CoinCollect.totalCoins < totalCoinsInLevel)
            {
                warningText.text = "Collect all coins first!";
                warningText.gameObject.SetActive(true);
                Invoke("HideWarning", 2f);
            }
            else
            {
                coinResultText.text = "Coins: " + CoinCollect.totalCoins;
                finishPanel.SetActive(true);
                Time.timeScale = 0f;
            }
        }
    }

    void HideWarning()
    {
        warningText.gameObject.SetActive(false);
    }

    public void GoToMainMenu()
    {
        Time.timeScale = 1f;
        CoinCollect.totalCoins = 0;
        SceneManager.LoadScene("MainMenu");
    }
}