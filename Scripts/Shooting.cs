using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour {

    public Rigidbody bullet;
    public float force = 2500f;
    private bool isPlayer;
   

    void Update()
    {

        if (Input.GetButtonDown("Fire1")&&isPlayer)
        {
              
            Rigidbody clone = Instantiate(bullet, new Vector3(transform.position.x, transform.position.y,transform.position.z), transform.rotation) as Rigidbody;
            Vector3 fwd = transform.TransformDirection(Vector3.up);
            clone.AddForce(fwd * force);
        
        }      

    }
    private void OnTriggerStay(Collider other)
    {
        if(other.tag=="Player")
        {
            isPlayer=true;
        }
    }
    void OnTriggerExit(Collider other)
    {

        if (other.tag.Equals("Player"))
        {
            isPlayer = false;
        }

    }




}
