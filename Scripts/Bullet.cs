using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
    private float timer = 0.0f;
    public float time;
	
	void Update ()
    {
        timer += Time.deltaTime;
        if (timer > time)
        {
            Destroy(gameObject);
        }
    }
}
