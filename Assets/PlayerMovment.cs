using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rd;
    float movementSpeed = 5f;
    float JumpForce = 5f;
    
    // Start is called before the first frame update
    void Start()
    {
        rd = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput.Input.GetAxis("Horizontal");
        float verticalInput.Input.GetAxis("Vertical");

        rd.velocity = new Vector3(horizontalInput * movementSpeed, rd.velocity.y, verticalInput * movementSpeed);

        if (Input.GetButtonDouwn("Jump"))
        {
            rd.velocity = new Vector3(rd.velocity.x, JumpForce, rd.velocity.z);
        }

    }
}