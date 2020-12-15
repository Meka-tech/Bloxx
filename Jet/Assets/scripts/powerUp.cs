using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerUp : MonoBehaviour
{
    public Transform[] spawnPoint;
    public GameObject PowerUp;
    public float timeToSpawn ;
    public float timeBetweenWaves ;

    void Start()
    {
        timeToSpawn = Random.Range(30f, 50f);
        timeBetweenWaves = Random.Range(20f, 50f);
    }
    // Update is called once per frame
    void Update()
    {
        if (Time.timeSinceLevelLoad >= timeToSpawn)
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
            if (randomIndex == i)
            {
                Instantiate(PowerUp, spawnPoint[i].position, Quaternion.identity);
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Block")
        {

            Destroy(collision.gameObject);
            Destroy(gameObject);

        }
    }
}
