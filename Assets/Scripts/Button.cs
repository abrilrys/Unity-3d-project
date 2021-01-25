using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;


public class Button : MonoBehaviour
{
    public Vector3 jump;
    public float jumpSpeed = 5f;
    public Vector3 jumpi;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
        Jump();



    }
    public void Jump()
    {
        jumpi= new Vector3(0.0f, 2.0f, 0.0f);
        rb.AddForce(jumpi * jumpSpeed, ForceMode.Impulse);
    }

}