using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerbounce : MonoBehaviour
{
    public Rigidbody rb;
    private GameObject obj;
    public float boost;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            obj = GameObject.FindGameObjectWithTag("Player");
            rb.AddForce(Vector3.up * boost, ForceMode.Impulse);
        }
    }
}
