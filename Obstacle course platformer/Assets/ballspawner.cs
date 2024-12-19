using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ballspawner : MonoBehaviour
{
    public GameObject ball;
    
    void Update()
    {
        Instantiate(ball, transform.position, Quaternion.identity);
    }
}
