using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpawner : MonoBehaviour
{
    public Transform[] spawnPoints; //Array of points where we can spawn the blocks

    public GameObject blockPrefab;

    private float timeToSpawn = 2f;

    public float timeBtwWaves = 2f;
    // Start is called before the first frame update
    void Update()
    {
        // Time.time -- time elapsed since the start of the game
        if (Time.time >= timeToSpawn)
        {
            SpawnBlocks();
            timeToSpawn = Time.time + timeBtwWaves;
        }
        
           
    }

    // Update is called once per frame
    void SpawnBlocks()
    {
        int randomIndex = Random.Range(0, spawnPoints.Length);
        // Choose a random spawn point from the spawn points array.
        for (int i=0; i< spawnPoints.Length; i++)
        {
            if (randomIndex != i)
            {
                Instantiate(blockPrefab, spawnPoints[i].position, Quaternion.identity);
                //Quarternion.identity locks the rotation from changing
                
            } 
        }
        
    }

    
}
