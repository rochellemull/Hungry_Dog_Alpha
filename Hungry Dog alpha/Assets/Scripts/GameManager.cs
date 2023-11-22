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
    public int maxScore=0;
    private int timer = 60;
    public bool isGameActive;
    public GameObject scoreGame;
    public GameObject winning;
    private Background background;
    
    

    // Start is called before the first frame update
    void Start()
    {
        score = 50;
    } 

    public void StartGame()
    {
        isGameActive = true;
        StartCoroutine(Timer());
        UpdateScore();
        

   
    }
    public void Update(){
       UpdateScore();
        
        
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
    public void AddScore(int newScore)
    {
        score += newScore;
    }
    public void UpdateScore()
    {
        
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
