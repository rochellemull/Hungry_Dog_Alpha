using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

//adding scoring Script
    public TextMeshProUGUI scoringText;
    public int score;
    public int finalScore = 0;
    public GameObject Score;
    public GameObject winning;
    public int maxScore;

    // Start is called before the first frame update
    void Start()
    {
        score = 50;

    }

    public void AddScore (int newScore){
       
    }

    public void UpdateScore(){
        score = score - 5;
        scoringText.text = "Score= " + score;
    }


    public void Update(){
       UpdateScore();

     if (score == maxScore){
        Score.SetActive(false);
        winning.SetActive(true);        //when the score Is equal to zero you will win
    }
    }
    public void SetUp(int score)
    {
        gameObject.SetActive(true);
        scoringText.text = score.ToString() + "points ";
    }
    public void RestartButton()
    {
        SceneManager.LoadScene("Restart");
    }

}
