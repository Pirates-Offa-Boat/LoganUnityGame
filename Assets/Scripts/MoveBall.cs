using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBall : MonoBehaviour
{
    public Rigidbody rb;
    public float moveSpeed = 10f;
    public float jumpForce = 20f;
    public bool isGrounded;
    public float gravityMultiplier = 4.5f;
    public float groundCheckDistance = 0.6f; // Distance to check for ground
    public LayerMask groundLayer; // Layer to detect ground objects
    public float ballMass = 1f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.mass = ballMass;
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
        }

        // Apply extra gravity when not grounded
        if (!isGrounded)
        {
            rb.AddForce(Vector3.down * gravityMultiplier, ForceMode.Acceleration);
        }

        // Check if grounded using raycast
        GroundCheck();
    }

    void GroundCheck()
    {
        // Cast a ray downwards to check for the ground
        RaycastHit hit;
        if (Physics.Raycast(transform.position, Vector3.down, out hit, groundCheckDistance, groundLayer))
        {
            isGrounded = true;
        }
        else
        {
            isGrounded = false;
        }
    }
}
