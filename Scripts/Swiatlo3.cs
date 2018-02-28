using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Swiatlo3 : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
           
         
                SceneManager.LoadScene(SceneManager.GetSceneAt(0).name);
            

        }
    }
}
