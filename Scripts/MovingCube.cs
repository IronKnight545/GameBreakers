using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingCube : MonoBehaviour
{

    Rigidbody rb;
    private bool isPlayer;
	void Start ()
    {

        rb = GetComponent<Rigidbody>();
	}

    private void OnTriggerStay(Collider other)
    {
        if (other.tag != "floor")
        {
            rb.isKinematic = false;
        }
        else
        {
            rb.isKinematic = true;
        }

        if (other.tag=="Player")
        {
            isPlayer = true;
        }
      
        if (Input.GetKey(KeyCode.LeftShift))
        {
           

                transform.Translate(new Vector3(-1, 0, 0) * 5* Time.deltaTime);



            
        }
        else
        {
            transform.Translate(new Vector3(0, 0, 0) * 5 * Time.deltaTime);
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
            GUI.Label(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 10, 100, 20), "Hold L-Shift to push","");
        }
    }
}
