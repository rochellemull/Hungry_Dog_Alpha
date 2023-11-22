using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

//adding scoring Script
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameOverText;
    public TextMeshProUGUI timerText;
    public Button restartButton;
    private int score;
    private int timer = 60;
    public bool isGameActive;
    private Background background;
    
    

    // Start is called before the first frame update
    void Start()
    {

    } 

    public void StartGame()
    {
        isGameActive = true;
        StartCoroutine(Timer());
        score = 50;
        UpdateScore(50);
        
       


    }
    public void Update(){
        if (isGameActive)
        {
            background.moveBackground(true);
        }
    }
    IEnumerator Timer()
    {
        while(isGameActive)
        {
            if (timer > 0)
            {
                timerText.text = "Timer: " + timer;
                yield return new WaitForSeconds(1);
                timer--;
            }
            else
            {
                GameOver();
            }

        }
    }

    public void UpdateScore(int scoreToAdd)
    {
        score -= scoreToAdd;
        scoreText.text = "Score: " + score;
    }
    public void GameOver()
    {
        gameOverText.gameObject.SetActive(true);
        restartButton.gameObject.SetActive(true);
        isGameActive = false;
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
