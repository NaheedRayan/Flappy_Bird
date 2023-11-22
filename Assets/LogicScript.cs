using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// extra
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore = 0;
    public Text scoreText;
    public GameObject gameOverScreen;


    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        playerScore += scoreToAdd;
        scoreText.text = playerScore.ToString();
    }


    public void restartGame()
    {
        //Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


    public void gameOver()
    {
        //Time.timeScale = 0;//for pausing the game
        gameOverScreen.SetActive(true);
    }

    public void OnApplicationQuit()
    {
        Application.Quit();
    }





}
