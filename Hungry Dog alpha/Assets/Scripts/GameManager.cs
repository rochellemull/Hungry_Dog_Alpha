using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagment;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text ScoringText;
    public int score;
    public int finalScore = 0;
    public gameObject Score;
    public GameObject winning;

    // Start is called before the first frame update
    void Start()
    {
        score = 50;

    }

    public void AddScore (int newScore){
       score += newScore;
    }

    public void UpdateScore(){
        scoreText.text = "Score= " + score;
    }


    public void Update(){
       UpdateScore();

     If (score == maxScore){
        Score.SetActive(false);
        winning.SetActive(true);        //when the score Is equal to zero you will win
    }
    }

}
