using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject fencePrefab;
    public GameObject bonePrefab;
    private float boneSpawn = 1.5f;
    private float delay = 1;
    private float intervalSpawn = 2f;
    
    
    public PlayerController player;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnFoodObjects", delay, boneSpawn);
        InvokeRepeating("SpawnObstacle", delay, intervalSpawn);
        player = GameObject.Find("Player").GetComponent<PlayerController>();
        
    }

    void SpawnFoodObjects()
    {
        Vector3 spawnFoodLocation = new Vector3(10, Random.Range(3, 8), 0);
       
        
        if (!player.gameOver)
        {

            Instantiate(bonePrefab, spawnFoodLocation, bonePrefab.transform.rotation);
                
            
            
                
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
