using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBall : MonoBehaviour
{
    public Rigidbody rb;
    public float moveSpeed = 10f;
    public float jumpForce = 15f;
    public bool isGrounded;
    public float gravityMultiplier = 2f; // Custom gravity multiplier

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Horizontal movement (X-axis)
        float moveX = 0;
        if (Input.GetKey(KeyCode.A))
            moveX = -1;
        if (Input.GetKey(KeyCode.D))
            moveX = 1;

        Vector3 movement = new Vector3(moveX * moveSpeed, rb.velocity.y, 0);
        rb.velocity = movement;

        // Jumping (Y-axis)
        if (Input.GetKeyDown(KeyCode.W) && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false; // Prevent double jump
        }

        // Apply extra gravity when not grounded
        if (!isGrounded)
        {
            rb.AddForce(Vector3.down * gravityMultiplier, ForceMode.Acceleration);
        }
    }

    // Detect ground collision to enable jumping again
    void OnCollisionEnter(Collision collision)
    {
        if (collision.contacts[0].normal.y > 0.5f) // Check if landing on a surface
        {
            isGrounded = true;
        }
    }

    void OnCollisionExit(Collision collision)
    {
        isGrounded = false; // When the ball leaves the ground
    }
}
