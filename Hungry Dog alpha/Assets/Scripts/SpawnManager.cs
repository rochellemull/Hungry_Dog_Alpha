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
    private PlayerController playerControllerS;
    private Vector3 spawnFoodLocation;
    private Vector3 spawnFenceLocation;
    public PlayerController player;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnFoodObjects", delay, intervalSpawn);
        InvokeRepeating("SpawnObstacle", delay, intervalSpawn);
        playerControllerS = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnFoodObjects()
    {
        spawnFoodLocation = new Vector3(30, Random.Range(5, 20), 0);
        int index = Random.Range(0, foodPrefab.Length);
       
        if (!playerControllerS.gameOver)
        {
            Instantiate(foodPrefab[index], spawnFoodLocation, foodPrefab[index].transform.rotation);
        }
        

        

    }
    void SpawnObstacle()
    {
        spawnFenceLocation = new Vector3(25, 0, 0);
        if (!playerControllerS.gameOver)
        {
            Instantiate(fencePrefab, spawnFenceLocation, fencePrefab.transform.rotation);
        }
    }
}
