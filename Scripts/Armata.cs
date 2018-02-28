using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Armata : MonoBehaviour
{
    private bool isPlayer;
    
    public Font fontt;

   

    private float angle;

    void Update()
    {
       
    }
    private void OnTriggerStay(Collider other)
    {
       
    
        isPlayer = true;
        if(Input.GetKey(KeyCode.W) &&angle<=40)
        {
            angle++;
            transform.Rotate(new Vector3(0, 0, -1) * 50 * Time.deltaTime);
          
            isPlayer = false;
          
        }
        if (Input.GetKey(KeyCode.S) && angle>=-35)
        {
            angle--;
            transform.Rotate(new Vector3(0, 0, 1) * 50 * Time.deltaTime);
            isPlayer = false;
          
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
