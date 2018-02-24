using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrzwiWiezienie : MonoBehaviour
{
    public Animator drzwi;
    public AudioSource sound;
    private bool isPlayer=true;
    public Font fontt;
    private float timer;
    private bool time=false;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Player"&&isPlayer==true)
        {
            sound.Play();
            drzwi.SetTrigger("Zamykanie");
            isPlayer = false;
          
          
        }
    }
    void OnGUI()
    {

        if (isPlayer == false&&time==false)
        {
            timer += Time.deltaTime;
        }
        if(timer >=1f && timer<=4f)
        { 
            GUIStyle myButtonStyle = new GUIStyle();
            myButtonStyle.fontSize = 20;
         


            myButtonStyle.font = fontt;


            myButtonStyle.normal.textColor = Color.white;




            GUI.Label(new Rect(Screen.width / 1.7f - 100, Screen.height / 2 - 10, 100, 20), "Ups...", myButtonStyle);
            
          
        }
        if(timer>=4)
        {
            time = true;
        }
    }

}
