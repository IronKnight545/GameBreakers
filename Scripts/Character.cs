using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Character : MonoBehaviour
{


    private Rigidbody rb;
    private string moveInputAxis = "Horizontal";
    public float moveSpeed = 2;

    public float fallMultipler = 2.5f;
    public float lowJumpMultipler = 2f;

    private float jumpForce = 5.0f;
    int jumpCount=0;
    bool grounded;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }
 
    void Update()
    {
        float moveAxis = Input.GetAxis(moveInputAxis);
        
        Move();
        Turn(moveAxis);
        Jump();

    }
    private void Move()
    {
        if (Input.GetButton(moveInputAxis))
        {

            transform.Translate(new Vector3(0, 0, 1) * moveSpeed * Time.deltaTime);

            

        }
    }
    private void Jump()
    {
        if (rb.velocity.y < 0)
        {
            rb.velocity += Vector3.up * Physics.gravity.y * (fallMultipler - 1) * Time.deltaTime;
        }

        if (Input.GetButtonDown("Jump")&&jumpCount<=1)
        {
            jumpCount++;
            rb.velocity = Vector3.up * jumpForce;
            grounded = false;
           
        }
        
        if(grounded==true)
        {
            jumpCount = 0;
        }
      
        


    }
    private void Turn(float input)
    {
        if (input > 0)
        {
            transform.rotation = Quaternion.Euler(0, -90, 0);
        }
        if (input < 0)
        {
            transform.rotation = Quaternion.Euler(0, 90, 0);
        }
    }
   
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag=="floor")
        {
            grounded = true;
        }
      
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.tag=="floor")
        {
            jumpCount = 2;
            grounded = false;
        }
    }

}
