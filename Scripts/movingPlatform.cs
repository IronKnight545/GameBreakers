using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingPlatform : MonoBehaviour
{

    
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player"||other.tag=="cube")
        {
          
            other.transform.parent = transform;
        }
    }
   


    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player"||other.tag=="cube")
        {
            other.transform.parent = null;

        }
    }
}
