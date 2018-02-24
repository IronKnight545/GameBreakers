using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUISaveGame : MonoBehaviour
{
    private bool isPlayer;
    public Font fontt;
    private bool isF;
    private float timer;

     void Update()
    {

        if(Input.GetKeyDown(KeyCode.F))
           {
            isF = true;
           }
    }
    void OnTriggerStay(Collider other)
    {

        if (other.tag.Equals("Player"))
        {
            isPlayer = true;
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



            if(isF==false)
            {
                GUI.Label(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 10, 100, 20), "Press F to save the game", myButtonStyle);
            }
            else if(isF==true&&timer<2)
            {
                GUI.Label(new Rect(Screen.width / 1.85f - 100, Screen.height / 2 - 10, 100, 20), " Saved!", myButtonStyle);
                timer += Time.deltaTime;
            }
          
           
          
        }
    }


}
