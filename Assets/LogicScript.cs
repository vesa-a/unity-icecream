using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
//LogicScript pitää kirjaa pisteistä ja sisältää metodeja joita kutsutaan muista skripteistä

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public GameObject creditsScreen;

    public void AddScore(int scoreToAdd)
    {
        if (Jäätelöskripti.tikkuElossa == true)
        {
            playerScore += scoreToAdd;
            scoreText.text = playerScore.ToString();
        }
        
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Jäätelöskripti.tikkuElossa = true;
    }

    public void DisplayGameOver()
    {
        gameOverScreen.SetActive(true);
    }

    public void DisplayCredits()
    {
        creditsScreen.SetActive(true);
    }

}
