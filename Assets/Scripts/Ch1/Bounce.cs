using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// GameDev.tv Challenge Club. Got questions or want to share your nifty solution?
// Head over to - http://community.gamedev.tv

public class Bounce : MonoBehaviour
{
    [SerializeField] float jumpForce = 1000f;
    
    void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<Rigidbody>() != null)
        {
            JumpyJumpy(other);
        }
    }

    void JumpyJumpy(Collider other)
    {
        Rigidbody rb = other.GetComponent<Rigidbody>();
        Vector3 jumpDir = new Vector3(0f, jumpForce, 0f) ;
        rb.AddForce(jumpDir);
    }
}
