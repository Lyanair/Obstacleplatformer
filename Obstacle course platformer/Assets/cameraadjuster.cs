using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraadjuster : MonoBehaviour
{
    private GameObject obj;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            obj = GameObject.FindGameObjectWithTag("Camera");
            obj.GetComponent<CameraManager>().cameraDist += 20;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            obj = GameObject.FindGameObjectWithTag("Camera");
            obj.GetComponent<CameraManager>().cameraDist -= 20;
        }
    }
}
