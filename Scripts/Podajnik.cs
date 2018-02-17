using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Podajnik : MonoBehaviour {

    public Rigidbody cube;
    public GameObject go;
    private bool isPlayer;
	void Start ()
    {
		
	}
    private void OnTriggerStay(Collider other)
    {
        if(other.tag=="Player")
        {
            isPlayer = true;
            if (Input.GetKeyDown(KeyCode.E))
            {
                Rigidbody clone = Instantiate(cube, new Vector3(go.transform.position.x, go.transform.position.y, go.transform.position.z), transform.rotation) as Rigidbody;
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
            GUI.contentColor = Color.black;
            GUI.Label(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 10, 100, 20), "Push E to pick up a cube", "");
        }
    }
}
