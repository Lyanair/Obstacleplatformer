using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallcontroller : MonoBehaviour
{
    public GameObject fallplatform;
    public float returnTime = 0.5f;

    void Update()
    {
        if (fallplatform.activeSelf == false)
        {
            StartCoroutine(Return(returnTime));
        }
    }

    IEnumerator Return(float time)
	{
		yield return new WaitForSeconds(time);
		fallplatform.SetActive(true);
	}
}
