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
            rb.position += Vector3.up/65;
        if (Input.GetKey(KeyCode.A))
            rb.position += Vector3.left/75;
        if (Input.GetKey(KeyCode.D))
            rb.position += Vector3.right/75;
    }
}
