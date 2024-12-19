using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class superjump : MonoBehaviour
{
    private GameObject obj;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            obj = GameObject.FindGameObjectWithTag("Player");
            obj.GetComponent<CharacterControls>().jumpHeight += 10;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            obj = GameObject.FindGameObjectWithTag("Player");
            obj.GetComponent<CharacterControls>().jumpHeight -= 10;
        }
    }
}
