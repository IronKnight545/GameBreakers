using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aktywator : MonoBehaviour
{
    public Animator animacja;
    bool isCube=false;
    private void OnTriggerStay(Collider other)
    {
        if(other.tag=="Player")
        {
            animacja.SetTrigger("Otwieranie");
        }
        if (other.tag == "cube")
        {
            animacja.SetTrigger("Otwieranie");
            isCube = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player" && isCube==false)
        {
            animacja.SetTrigger("Zamykanie");
        }
    }
}
