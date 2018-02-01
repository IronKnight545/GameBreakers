﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightRay : MonoBehaviour
{
    public float rayDistance;
    public int damage;

    void LateUpdate()
    {
        
      
        RaycastHit hit;
        Ray lightRay = new Ray(transform.position, Vector3.down);
        
        if (Physics.Raycast(lightRay, out hit, rayDistance))
        {
           
            if (hit.collider.tag == "Player")
            {
               
                Debug.Log("Rezi cię światło");
                hit.collider.SendMessage("Damage", damage);
            }
           
        } 

       
    }

}
