using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject fencePrefab;
    public GameObject[] foodPrefab;
    private float delay = 2;
    private float intervalSpawn = 1.5f;
    private float rotatingSpeed;
    //public GameObject ball;
    //public GameObject bone;
    private Vector3 spawnFenceLocation;
    public PlayerController player;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnFoodObjects", delay, intervalSpawn);
        InvokeRepeating("SpawnObstacle", delay, intervalSpawn);
        player = GameObject.Find("Player").GetComponent<PlayerController>();
        //ball = GameObject.FindWithTag("Ball");
        //bone = GameObject.FindWithTag("Bone");
    }

    // Update is called once per frame
    void Update()
    {
        //ball.transform.Rotate(90, 0.0f, 0);
       // bone.transform.Rotate(90, 0, 0);
    }
    void SpawnFoodObjects()
    {
        Vector3 spawnFoodLocation = new Vector3(10, Random.Range(0, 5), 0);
     
        int index = Random.Range(0, foodPrefab.Length);


        if (!player.gameOver)
        {
            Instantiate(foodPrefab[index], spawnFoodLocation, foodPrefab[index].transform.rotation);
        }




    }
    
    void SpawnObstacle()
    {
        spawnFenceLocation = new Vector3(15, 0, 0);
        if (!player.gameOver)
        {
            Instantiate(fencePrefab, spawnFenceLocation, fencePrefab.transform.rotation);
        }
    }
  
}
