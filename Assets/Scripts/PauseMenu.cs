using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject pausePanel;
    [SerializeField] GameObject pauseBotton;
    private bool isPaused = false;

    public void PauseGame()
    {
        pausePanel.SetActive(true);
        pauseBotton.SetActive(false);
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void ResumeGame()
    {
        pausePanel.SetActive(false);
        pauseBotton.SetActive(true);
        Time.timeScale = 1f;
        isPaused = false;
    }

    public void ExitLevel()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1f;
        isPaused = false;
    }
}
