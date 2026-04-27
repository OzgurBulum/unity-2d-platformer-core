using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    public GameObject gameOverPanel;

    void OnEnable()
    {
        PlayerHealth.OnPlayerDied += ShowGameOver;
    }

    void OnDisable()
    {
        PlayerHealth.OnPlayerDied -= ShowGameOver;
    }

    void ShowGameOver()
    {
        gameOverPanel.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Restart()
    {
        Time.timeScale = 1f;
        CoinCollect.totalCoins = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GoToMainMenu()
    {
        Time.timeScale = 1f;
        CoinCollect.totalCoins = 0;
        SceneManager.LoadScene("MainMenu");
    }
}