using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject gameOverPanel;
    public void Start()
    {
        gameOverPanel.SetActive(false);
    }
    public void GameOver()
    {
        gameOverPanel.SetActive(true);
    }
    public void ReStart()
    {
        SceneManager.LoadScene("Snake");
    }
   
}
