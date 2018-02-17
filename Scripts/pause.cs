using UnityEngine;
using System.Collections;
using UnityEngine.UI;

using UnityEngine.SceneManagement;


public class pause : MonoBehaviour

{

   static public Canvas canvas;
    
    
    
    
    void Start()
    {


      
        canvas = GetComponent<Canvas>();
        canvas.enabled = false;
      
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            canvas.enabled = !canvas.enabled;
            Time.timeScale = Time.timeScale = 0;
  
               
            
        }
        if(canvas.enabled==false)
        {
            Time.timeScale = Time.timeScale = 1;
        }
      
        
        

        
    }
     public void Wznow ()
    {
        Time.timeScale = Time.timeScale = 1;
        canvas.enabled = false;
    }
    public void Menu ()
    {
     SceneManager.LoadScene("Menu");
    }
    
    
}


