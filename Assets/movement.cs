using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForece = 300f;

    void Update()
    {
        if (Input.GetKey("w"))       
            rb.AddForce( 0, forwardForece * Time.deltaTime, 0);        
        else if (Input.GetKey("s"))       
            rb.AddForce(0, -forwardForece * Time.deltaTime, 0);       
        else if (Input.GetKey("a"))      
            rb.AddForce(-forwardForece * Time.deltaTime, 0,  0);       
        else if (Input.GetKey("d"))      
            rb.AddForce(forwardForece * Time.deltaTime, 0, 0);
        else
            rb.velocity = Vector3.zero;
    }
}
