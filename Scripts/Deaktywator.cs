using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deaktywator : MonoBehaviour
{
    public Light lightt;
    public GameObject go;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "cube")
        {

            go.active = false;
            lightt.enabled = false;
         
          

        }
    }
}
