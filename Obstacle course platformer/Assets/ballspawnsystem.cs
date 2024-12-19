using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballspawnsystem : MonoBehaviour
{
    public Transform[] spawnLocation;
    public int spawnIndex;
    public GameObject ball;
    private float spawnTimer;
    public float spawnInterval;

    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(spawnTimer <=0)
        {
            spawnIndex = Random.Range(0,spawnLocation.Length);
            Instantiate(ball, spawnLocation[spawnIndex].position,Quaternion.identity);
            spawnTimer = spawnInterval;
        }
        else
        {
            spawnTimer -= Time.fixedDeltaTime;
        }
    }
}
