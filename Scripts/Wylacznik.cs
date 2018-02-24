using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wylacznik : MonoBehaviour {


    public int size;
 
    public Light[] light1;
 
    public float time = 5.0f;
    bool isTimer=false;
    private float timer = 0;


    private bool isPlayer;
    public Font fontt;

    void Update()
    {
             
        if (isTimer==true)
        {
            
            timer += Time.deltaTime;
           
            if (timer>=time)
            {
                timer = 0;
                LightRay.x = true;
             
                light1[size].enabled = true;

                isTimer = false;
                
                
            }
        }
    }
    private void OnTriggerStay(Collider other)
    {
        
        if(other.tag=="Player")
        {
            isPlayer = true;
            if (Input.GetKeyDown(KeyCode.E))
            {
               
                    light1[size].enabled = false;
                

                isTimer = true;
                LightRay.x = false;
               
                         
               
            }
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




            GUI.Label(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 10, 100, 20), "Press E to turn the light off", myButtonStyle);
        }
    }

}
