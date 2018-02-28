using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUIArmata : MonoBehaviour {

    private bool isPlayer;
    public Font fontt;
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




            GUI.Label(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 10, 100, 20), "Use W to up, S to down", myButtonStyle);
        }
    }

}
