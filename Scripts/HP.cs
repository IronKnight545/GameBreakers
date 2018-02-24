using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class HP : MonoBehaviour
{
    public int playerHp = 100;
  
  
    public void Damage(int damage)
    {
        
        playerHp -= damage;
   
      
        Debug.Log(playerHp + "HP");
     
       
        if (playerHp<=0)
        {
            SceneManager.LoadScene(SceneManager.GetSceneAt(0).name);
            playerHp = 1000;
        }
    }

}