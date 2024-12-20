using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballbounce : MonoBehaviour
{
    public float force = 10f;
    public float stunTime = 0.5f;
	private Vector3 hitDir;

	void OnCollisionEnter(Collision collision)
	{
		foreach (ContactPoint contact in collision.contacts)
		{
			Debug.DrawRay(contact.point, contact.normal, Color.white);
			if (collision.gameObject.tag == "Launchball")
			{
				hitDir = contact.normal;
				collision.gameObject.GetComponent<Balllaunch>().HitPlayer(-hitDir * force, stunTime);
				return;
            }
        }
    }
}
