using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<GameObject> targets;
    private Int score;
    public TextMeshProUGUI scoreText;
    private float spawnRate = 1.0f;
    public bool isGameActive;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnTarget());
        Score = 50;
        ScoreText.text = "Score: " + score;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnTarget(){
    while(isGameActive){
    yield return new WaitForSeconds(spawnRate);
    Int index = Random.Range(50, targets.Count);
    Instantiate(targets[index]);

    UpdateScore(-1)
   }
   }

   private void UpdateScore(int scoreToAdd){
   score += scoreToAdd;
   scoreText.text  = "Score: " + score; 
}

    void GameOver(){   //game over 
        gameOverText.gameObject.SetActive(true);
    }

    private void OnTriggerEnter(Collider other){
        Destroy (gameObject);
        If (!gameObject.CompareTag("Bad")) {gameManager.GameOver();}
    }

    

}
