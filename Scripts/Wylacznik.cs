using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wylacznik : MonoBehaviour {

   public Light light1;
   public Light light2;
   public float time = 5.0f;
    bool isTimer=false;
    private float timer = 0;
     void Update()
    {

      
        if (isTimer==true)
        {

            timer += Time.deltaTime;
           
            if (timer>=time)
            {
                timer = 0;
                LightRay.x = true;
                light1.enabled = true;
                light2.enabled = true;
                isTimer = false;
                
                
            }
        }
    }
    private void OnTriggerStay(Collider other)
    {
        
        if(other.tag=="Player")
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                isTimer = true;
                LightRay.x = false;
                light1.enabled = false;
                light2.enabled = false;
               
            }
        }
    }
}
