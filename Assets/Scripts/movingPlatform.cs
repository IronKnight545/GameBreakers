using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingPlatform : MonoBehaviour
{
    public Rigidbody player;
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            other.transform.parent = transform;
        }
    }
   


    private void OnTriggerExit(Collider other)
    {
        if (other.transform.tag == "Player"||other.tag=="cube")
        {
            other.transform.parent = null;

        }
    }
}
