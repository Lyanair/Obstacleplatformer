using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour
{
    public Rigidbody rb;
    public float rotx;
    public float roty;
    public float rotz;


    // Update is called once per frame
    void FixedUpdate()
    {
	    rb.AddTorque(rotx, roty, rotz, ForceMode.Impulse);
	}
}
