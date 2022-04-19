using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float playerSpeed;
    public Rigidbody rb;
    bool isGrounded = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(isGrounded == false)
        {
            float inputX = Input.GetAxis("Horizontal");
            float inputY = Input.GetAxis("Vertical");

            rb.MovePosition(new Vector3(inputX * playerSpeed, inputY * playerSpeed, 0));
        }
        else
        {
            isGrounded = true;
        }
      

    }
}
