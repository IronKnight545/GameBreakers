using UnityEngine;
using System.Collections;


public class AudioManager : MonoBehaviour
{
   
    public AudioListener audiolistener;
  
	void Start ()
    {
        audiolistener = GetComponent<AudioListener>();
      
       
	}
	
	
	public void vol(float voll)
    {
       AudioListener.volume = voll;
      
	}
}
