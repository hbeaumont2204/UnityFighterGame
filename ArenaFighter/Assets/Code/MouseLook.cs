using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.Animations;
using System.Xml.Serialization;

public class MouseLook : MonoBehaviour
{
    private Controller controls;
    private float MouseSensitivity = 100f;
    private float xRotation = 0f;

    private Vector2 mouseLook;
    private Transform playerBody;

    private void Awake()
    {
        playerBody = transform.parent;

        controls = new Controller();
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        Look();
    }

    private void Look()
    {
        mouseLook = controls.Player.Look.ReadValue<Vector2>();

        float mouseX = mouseLook.x * MouseSensitivity * Time.deltaTime;
        float mouseY = mouseLook.y * MouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90);

        transform.localRotation = Quaternion.Euler(xRotation, 0, 0);
        playerBody.Rotate(Vector3.up * mouseX);
    }

    private void OnEnable()
    {
        controls.Enable();
    }

    private void OnDisable()
    {
        controls.Disable();
    }
}
