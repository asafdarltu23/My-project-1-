using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRingSpawning : MonoBehaviour
{
    //Defining an array to hold the possible spawn points
    public GameObject[] spawnPoints = new GameObject[6];
    //Seconds between instantiation of each ring
    public float spawnRate = 1.0f;
    //A counter used to keep track of the time between ring instantiations
    private float spawnCounter = 0.0f;

    // Update is called once per frame
    void Update()
    {
        //THE DELLTA TIME IS ADDED TO THE COUNTER TO KEEP TRACK OF TIME
        spawnCounter += Time.deltaTime;

        //If the counter has surpassed the rate, we're ready to spawn something
        if(spawnCounter > spawnRate)
        {
            int randomIndex = Random.Range(0, spawnPoints.Length);
            //Spawn something
            Debug.Log("Spawning ring at " + spawnPoints[randomIndex].name);
            //Counter is reset
            spawnCounter = 0.0f;
        }
    }
}
