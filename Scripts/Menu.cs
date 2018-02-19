using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Menu : MonoBehaviour
{
 
    
    public Canvas menu;
  
  
   
   
    void Start()
    {
           
        menu = GetComponent<Canvas>();
        menu.enabled = true;
    }
  

    public void Play ()
    {

       SceneManager.LoadScene(0);
    }
   

    public void Exit()
    {
        Application.Quit();

    }
    
  
}
