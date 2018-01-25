using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour {


    private Rigidbody rigidbody;
    private string moveInputAxis = "Horizontal";
    public float moveSpeed = 2;


    private float jumpForce = 20.0f;
    
   
    void Start ()
    {
        rigidbody = GetComponent<Rigidbody>();
        controller = GetComponent<CharacterController>();
	}
	
	void Update ()
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

            transform.Translate(new Vector3(0,0,1)*moveSpeed* Time.deltaTime);

          

        }
    }
    private void Jump()
    {
       
            if(Input.GetButtonDown("Jump"))
            {
            transform.Translate(new Vector3(0, 1, 0) * jumpForce *Time.fixedDeltaTime);
            }
            
        
       
    }
    private void Turn(float input)
    {
        if(input>0)
        {
            transform.rotation = Quaternion.Euler(0, -90, 0);
        }
        if(input<0)
        {
            transform.rotation = Quaternion.Euler(0, 90, 0);
        }
    }
}
