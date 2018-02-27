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
        Debug.Log(angle);
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
