using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Armata : MonoBehaviour
{
    private bool isPlayer;
    
    public Font fontt;

    void Update()
    {
       
    }
    private void OnTriggerStay(Collider other)
    {
        float angle = transform.rotation.y;
    
        isPlayer = true;
        if(Input.GetKey(KeyCode.W)&&angle<=0.99f)
        {
            transform.Rotate(new Vector3(0, 0, -1) * 50 * Time.deltaTime);
            isPlayer = false;
          
        }
        if (Input.GetKey(KeyCode.S) && angle >= 0.4f)
        {
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
   

    
    void OnGUI()
    {
        if (isPlayer)
        {
            GUIStyle myButtonStyle = new GUIStyle();
            myButtonStyle.fontSize = 20;



            myButtonStyle.font = fontt;


            myButtonStyle.normal.textColor = Color.white;



         
                GUI.Label(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 10, 100, 20), "Hold W to up, S to down", myButtonStyle);
          
          
            
               
             
            



        }
    }

}
