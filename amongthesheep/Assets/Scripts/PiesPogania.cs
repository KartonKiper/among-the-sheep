using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PiesPogania : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody myBody;
    public float moveForce = 50f;
    void Awake()
    {
        myBody = GetComponent<Rigidbody>();
    }
        void onCollisionEnter(Collider other)
    {
        if(other.gameObject.tag == "Pies")
        {
            myBody.velocity = new Vector3(myBody.velocity.x, myBody.velocity.y);
        }
    }
}
