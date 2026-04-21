using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PauseManager : MonoBehaviour
{
    public GameObject pausePanel;
    private bool isPaused = false;
    private PlayerControls controls;

    void Awake()
    {
        controls = new PlayerControls();
        controls.GamePlay.Pause.performed += ctx => TogglePause();
    }

    void Start()
    {
        
        if (pausePanel != null)
        {
            pausePanel.SetActive(false);
        }
    }

    void OnEnable()
    {
        controls.GamePlay.Enable();
    }

    void OnDisable()
    {
        controls.GamePlay.Disable();
    }
    
    public void TogglePause()
    {
        isPaused = !isPaused;

        if (isPaused)
        {
            pausePanel.SetActive(true);
            Time.timeScale = 0f;
        }
        else
        {
            pausePanel.SetActive(false);
            Time.timeScale = 1f;
        }
    }

    public void Resume()
    {
        isPaused = false;
        pausePanel.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Restart()
    {
        Time.timeScale = 1f; 
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Quit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}