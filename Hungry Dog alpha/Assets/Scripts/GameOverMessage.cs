using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagment;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

public Text scoreText;

public void SetUp(int score){
    gameObject.SetActive(true);
    scoreText.text = score.ToString() + "points ";
}

public void RestartButton(){
    GameManager.LoadScene("Restart");
}
}
