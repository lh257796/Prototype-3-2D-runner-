using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    public float JumpForce = 10;
    // Start is called before the first frame update
    void Start()
    {
        //don't have access automatically to RigidBody, since not on every object
        playerRb = GetComponent<Rigidbody>();
        //<> gives you a type of something, ie to find a type of anything, like a collider
        //need () to call it
        //apply forces
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerRb.AddForce(Vector3.up * JumpForce, ForceMode.Impulse);
            //forceMode.impulse immediately applies force

        }

    }
}
