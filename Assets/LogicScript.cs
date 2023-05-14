using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
//LogicScript pit�� kirjaa pisteist� ja sis�lt�� metodeja joita kutsutaan muista skripteist�

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public GameObject creditsScreen;

    public void AddScore(int scoreToAdd)
    {
        if (J��tel�skripti.tikkuElossa == true)
        {
            playerScore += scoreToAdd;
            scoreText.text = playerScore.ToString();
        }
        
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        J��tel�skripti.tikkuElossa = true;
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
