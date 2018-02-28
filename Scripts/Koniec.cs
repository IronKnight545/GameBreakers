using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Koniec : MonoBehaviour
{

    public Animator animacja;
    public AudioSource sound;
    public AudioClip clip;

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
           
            animacja.SetTrigger("Zamykanie");
        }
    }
    private void OnTriggerEnter(Collider other)
    {
      if(other.tag=="Player")
        {
            sound.Play();
        }
    }
}
