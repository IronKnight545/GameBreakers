using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour {

    public Rigidbody bullet;
    public float force = 2500f;
   
   

    void Update()
    {

        if (Input.GetButtonDown("Fire1"))
        {
              
            Rigidbody clone = Instantiate(bullet, new Vector3(transform.position.x, transform.position.y+1,transform.position.z+1), transform.rotation) as Rigidbody;
            Vector3 fwd = transform.TransformDirection(Vector3.forward);
            clone.AddForce(fwd * force);
        
        }      

    }
    


       
    
}
