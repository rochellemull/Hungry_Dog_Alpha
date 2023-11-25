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
    public Button mainMenu;
    private int score;
    public int maxScore=0;
    public  float timer = 60.0f;
    public bool isGameActive;
    public GameObject scoreGame;
    public GameObject winning;
    public Image endScene;
    
    

    // Start is called before the first frame update
    void Start()
    {
       
        score = 50;
       
       
    } 

    public void StartGame()
    {
        isGameActive = true;
        
        UpdateScore();
        

   
    }
    public void Update(){
       UpdateScore();
        timer -= Time.deltaTime;
        timerText.SetText("Time: " + Mathf.Round(timer));
        
        if (timer < 1)
        {
            GameOver();
        }


    }
    
    public void AddScore(int newScore)
    {
        score += newScore;
        
        //score.this;
    }
    public void UpdateScore()
    {
        
        scoreText.text = "Score: " + score;
    }
   

    public void GameOver()
    {

        gameOverText.gameObject.SetActive(true);
        restartButton.gameObject.SetActive(true);
        mainMenu.gameObject.SetActive(true);
        endScene.gameObject.SetActive(true);
        isGameActive = false;
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void MainMenu()
    {
        SceneManager.LoadSceneAsync(0);
    }

}
