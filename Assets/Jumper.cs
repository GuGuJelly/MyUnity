using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumper : MonoBehaviour
{

    public float jumpPower;
    public Rigidbody rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            rigidbody.AddForce(Vector3.up*jumpPower,ForceMode.Impulse);
        }
    }
}
