using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Podajnik : MonoBehaviour {

    public Rigidbody cube;
    public GameObject go;
    private bool isPlayer;
    public Font fontt;
    public int counter;
    
    private void OnTriggerStay(Collider other)
    {
        if(other.tag=="Player")
        {
            isPlayer = true;
            if (Input.GetKeyDown(KeyCode.E)&&counter>=1 )
            {
                Instantiate(cube, new Vector3(go.transform.position.x, go.transform.position.y, go.transform.position.z), transform.rotation) ;
                counter--;
            }
           
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
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




            GUI.Label(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 10, 100, 20), "Use E to pick up a cube", myButtonStyle);
            GUI.Label(new Rect(Screen.width / 2 - 100, Screen.height / 3 - 10, 100, 20), "Remain: "+counter.ToString(), myButtonStyle);
        }
    }
}
