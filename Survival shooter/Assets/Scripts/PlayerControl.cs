using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       Rigidbody rb = GetComponent<Rigidbody>();
       if (Input.GetKeyDown("W"))
        {
            rb.AddForce(Vector3.forward);
        }
        if (Input.GetKeyDown("S"))
        {
            rb.AddForce(Vector3.back);
        }
        if (Input.GetKeyDown("A"))
        {
            rb.AddForce(Vector3.left);
        }
        if (Input.GetKeyDown("D"))
        {
            rb.AddForce(Vector3.forward);
        }
        if (Input.GetKeyDown("space"))
        {
            rb.AddForce(Vector3.up);
        }
    }
}
