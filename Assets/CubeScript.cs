using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;


public class CubeScript : MonoBehaviour
{
   
    
    public float speed = 1f;
    public float jumpSpeed = .1f;
    //public Vector3 jumpi;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
    
        rb = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
        float xDir = Input.GetAxis("Horizontal");
        float zDir = Input.GetAxis("Vertical");
        Vector3 moveDir = new Vector3(xDir, 0.0f, zDir);
        transform.position += moveDir * speed;
        

    }
    public void Jump()
    {
        // jumpi = new Vector3(0.0f, 2.0f, 0.0f);
        rb.AddForce(new Vector3(0, 1, 0), ForceMode.Impulse);
       
    }

}

