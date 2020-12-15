using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockSpawner : MonoBehaviour
{
    public Transform[] spawnPoint;
    public GameObject blockPrefab;
    private float timeToSpawn = 2f;
    public float timeBetweenWaves = 1f;
   

    // Update is called once per frame
    void Update()
    {
        if(Time.time >= timeToSpawn)
        {
            spawnBlocks();
            timeToSpawn = Time.time + timeBetweenWaves;
        }
        
    }
    void spawnBlocks()
    {
        int randomIndex = Random.Range(0, spawnPoint.Length);


        for (int i = 0; i < spawnPoint.Length; i++)
        {
            if (randomIndex != i)
            {
                Instantiate(blockPrefab, spawnPoint[i].position, Quaternion.identity);
            }
        }
    }
}   

