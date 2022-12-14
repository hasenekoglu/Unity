using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public GameObject gameOverPanel;
    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }

    public void OpenGameOverPanel()
    {
        gameOverPanel.SetActive(true);
    }
}
