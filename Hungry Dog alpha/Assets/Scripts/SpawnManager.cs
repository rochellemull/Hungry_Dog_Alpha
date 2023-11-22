using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject fencePrefab;
    public GameObject ballPrefab;
    public GameObject bonePrefab;
    private float delay = 2;
    private float intervalSpawn = 1.5f;
    
    int countBone = 0;
    private Vector3 spawnFenceLocation;
    public PlayerController player;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnFoodObjects", delay, intervalSpawn);
        InvokeRepeating("SpawnObstacle", delay, intervalSpawn);
        player = GameObject.Find("Player").GetComponent<PlayerController>();
        
    }

    void SpawnFoodObjects()
    {
        Vector3 spawnFoodLocation = new Vector3(10, Random.Range(0, 5), 0);
        
        
        if (!player.gameOver)
        {
            if (countBone != 5)
            {
                Instantiate(bonePrefab, spawnFoodLocation, bonePrefab.transform.rotation);
                countBone++;
            }
            else if(countBone == 5) {
                Instantiate(ballPrefab,spawnFoodLocation, ballPrefab.transform.rotation);
                countBone = 0;  
            }
        }
    }
    
    void SpawnObstacle()
    {
        Vector3 spawnFenceLocation = new Vector3(10,0, 0);
        
        
        if (!player.gameOver)
        {
            Instantiate(fencePrefab, spawnFenceLocation, fencePrefab.transform.rotation);
        }
    }
  
}
