using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float playerSpeed;
    public float playerJumpForce;
     Rigidbody rb;
    //bool isGrounded = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
            float inputX = Input.GetAxis("Horizontal");
            float inputY = Input.GetAxis("Vertical");
            transform.Translate(Vector3.forward* inputY* playerSpeed* Time.deltaTime);
            transform.Translate(Vector3.right * inputX * playerSpeed * Time.deltaTime);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * playerJumpForce, ForceMode.Impulse);
        }

        

        //rb.MovePosition(new Vector3(inputX * playerSpeed, inputY * playerSpeed, 0));




    }
}
