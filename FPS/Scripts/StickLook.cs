using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class StickLook : MonoBehaviour
{
    PlayerControls controls;
    public float sensitivity = 100f;
    public Transform playerBody;
    float xRotation = 0f;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float rotationX = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        float rotationY = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;

        xRotation -= rotationY;
        xRotation = Mathf.Clamp(xRotation, -90F, 90F);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        playerBody.Rotate(Vector3.up * rotationX);
    }
}
