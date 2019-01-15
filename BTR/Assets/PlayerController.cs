using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// only handles player movement and interactions with input
// camera controller will be another script on this object
public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    public float jumpHeight;
    public float gravity;

    private CharacterController cc;
    private Vector2 inputVector;

    // Start is called before the first frame update
    void Start()
    {
        cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        GetInput();
        Movement();
    }

    // store the input in a vector for later use
    private void GetInput()
    {
        inputVector = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
    }

    // move the character according to the input
    private void Movement()
    {
        Vector3 movement = new Vector3();
        movement += transform.forward * inputVector.y * moveSpeed * Time.deltaTime;
        movement += transform.right   * inputVector.x * moveSpeed * Time.deltaTime;
        if (!cc.isGrounded)
        {
            movement += Vector3.up * -1 * gravity * Time.deltaTime;
            Debug.Log("Falling");
        }
        cc.Move(movement);
    }
}
