using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercamera : MonoBehaviour
{
    public float sensX;
    public float sensY;

    public Transform orientation;

    float Xrot;
    float Yrot;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void Update()
    {
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensX;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensY;

        Yrot += mouseX;
        Xrot -= mouseY;
        Xrot = Mathf.Clamp(Xrot, -90f, 90f);

        transform.rotation = Quaternion.Euler(Xrot, Yrot, 0);
        orientation.rotation = Quaternion.Euler(0, Yrot, 0);
    }
}
