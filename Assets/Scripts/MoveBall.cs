using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBall : MonoBehaviour
{

    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
            rb.position += Vector3.up/100;
        if (Input.GetKey(KeyCode.A))
            rb.velocity += Vector3.left/100;
        if (Input.GetKey(KeyCode.D))
            rb.velocity += Vector3.right/100;
    }
}
