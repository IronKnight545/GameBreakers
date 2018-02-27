using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Swiatlo : MonoBehaviour
{
    public ParticleSystem swiatlo;
    public float time;
    public float breakk;
    private float timer;
    bool isLight;

     void Update()
    {
       
        timer += Time.deltaTime;
        if(timer>=time)
        {
            swiatlo.enableEmission = false;
            isLight = false;
           
        }
        if(timer>=time+breakk)
        {
            swiatlo.enableEmission = true;
            isLight = true;
            timer = 0;
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if(other.tag=="Player")
        {
            if(isLight==true)
            {
                SceneManager.LoadScene(SceneManager.GetSceneAt(0).name);
            }
          
        }
    }
}
