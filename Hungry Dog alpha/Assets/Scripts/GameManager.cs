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
    public TextMeshProUGUI timerText;
    
    
    private int score;
    public int maxScore=0;
    // inital value for timer
    public  float timer = 60.0f;
    public bool isGameActive;
    public GameObject scoreGame;
   
    // game over scene objects
    public Image endScene;
    public Button restartButton;
    public TextMeshProUGUI gameOverText;
    public Button mainMenu;



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
        // will create timer and make it decrease
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
   

    // will change what appears when the game is over
    public void GameOver()
    {

        gameOverText.gameObject.SetActive(true);
        restartButton.gameObject.SetActive(true);
        mainMenu.gameObject.SetActive(true);
        endScene.gameObject.SetActive(true);
        isGameActive = false;
    }
    //will restart game
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    // will load start menu
    public void MainMenu()
    {
        SceneManager.LoadSceneAsync(0);
    }

}
