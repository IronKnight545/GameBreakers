using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Armata : MonoBehaviour
{
    private bool isPlayer;
  
    private void OnTriggerStay(Collider other)
    {
        float angle = transform.rotation.z;
        isPlayer = true;
        if(Input.GetKey(KeyCode.W)&&angle>=0.22f)
        {
            transform.Rotate(new Vector3(0, 0, -1) * 50 * Time.deltaTime);
            isPlayer = false;
          
        }
        if (Input.GetKey(KeyCode.S) && angle <= 0.99f)
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
            GUI.contentColor = Color.black;
            GUI.Label(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 10, 100, 20), "Hold W to up, S to down", "");
        }
    }

}
