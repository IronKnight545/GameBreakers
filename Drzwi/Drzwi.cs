using UnityEngine;
using System.Collections;

public class Drzwi : MonoBehaviour
{
    public Animator DrzwiPivolt;
    bool x = false;
   
    bool tak = false;
  
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.E)&&x==true)
        {
           
            
       
            if(tak==false)
            {
                DrzwiPivolt.SetTrigger("Otwieranie");
                tak = true;
            }
            else
            {
                DrzwiPivolt.SetTrigger("Zamykanie");
                tak = false;
            }
        }
       
    }
    void OnTriggerStay(Collider other)
    {
         if(other.tag=="Player")
        {

            x = true;
        }
           
    }
    void OnTriggerExit(Collider other)
    {

        if (other.tag == "Player")
        {

            x = false;
        }

    }



}


    
      
    
    
    

