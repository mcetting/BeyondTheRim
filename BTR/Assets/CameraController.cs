using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// controls the fps camera attatched to the player
// only for ps4 controller
public class CameraController : MonoBehaviour
{
    public float inputSensitivity;
    private GameObject myCamera;
    private Vector2 rightStickInput;

    // Start is called before the first frame update
    void Start()
    {
        myCamera = transform.GetChild(1).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        GetInput();
        Movement();
    }

    // stores the right stick input
    private void GetInput()
    {
        rightStickInput = new Vector2(Input.GetAxis("HorizontalRight"), Input.GetAxis("VerticalRight"));
    }

    // handles the movement caused by right stick input
    private void Movement()
    {
        transform.Rotate(          Vector3.up    * rightStickInput.x * inputSensitivity);
        myCamera.transform.Rotate(-Vector3.right * rightStickInput.y * inputSensitivity);
    }
}
