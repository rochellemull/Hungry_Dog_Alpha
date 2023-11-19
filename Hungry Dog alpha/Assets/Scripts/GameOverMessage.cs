


public Text scoreText;

public void SetUp(int score){
    gameObject.SetActive(true);
    scoreText.text = score.ToString() + "points ";
}

public void RestartButton(){
    GameManager.LoadScene("Restart");
}
