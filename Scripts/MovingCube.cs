using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingCube : MonoBehaviour
{

    Rigidbody rb;
 
   
    private string moveInputAxis = "Horizontal";

    void Start ()
    {

        rb = GetComponent<Rigidbody>();
	}
     void Update()
    {
        RaycastHit hit;
        Ray isFloor = new Ray(transform.position, Vector3.down);

        if (Physics.Raycast(isFloor, out hit, 10))
        {
            if (hit.collider.tag != "floor")
            {
                rb.isKinematic = false;
            }
        }
    }
    private void OnTriggerStay(Collider other)
    {

        float moveAxis = Input.GetAxis(moveInputAxis);

        if (other.tag=="Player")
        {


            if (Input.GetKey(KeyCode.LeftShift))
            {


                transform.Translate(new Vector3(moveAxis, 0, 0) * 5 * Time.deltaTime);


            }
          

        }
        if (other.tag == "cube")
        {
            rb.isKinematic = false;
        }


    }

   
   
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag =="cube")
        {
            rb.isKinematic = false;
        }
      
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.collider.tag == "cube")
        {
            rb.isKinematic = true;
        }

    }
}
