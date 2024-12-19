using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balllaunch : MonoBehaviour
{
    private float pushForce;
	private Vector3 pushDir;
    public Rigidbody rb;

    
    public void HitPlayer(Vector3 velocityF, float time)
	{
		rb.velocity = velocityF;

		pushForce = velocityF.magnitude;
		pushDir = Vector3.Normalize(velocityF);
    }
}
