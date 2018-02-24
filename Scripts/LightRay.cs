using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightRay : MonoBehaviour
{
    public float rayDistance;
    public int damage;
    public GameObject go;
    public Light lightt;
  
    public static bool x;

     void Start()
    {
        
        x = true;
    }
    void LateUpdate()
    {
       
        for (int i = 0; i < 50; i++)
        {

            RaycastHit hit;
            Vector3 target = RandomSpotLightCirclePoint(lightt);
         
            Ray lightRay = new Ray(go.transform.position, target);
            Debug.DrawRay(lightRay.origin, lightRay.direction);
             

            if(Physics.Raycast(lightRay, out hit, rayDistance))
        {

                if (hit.collider.tag == "Player" && x == true)
                {


                       hit.collider.SendMessage("Damage", damage);
                 }

               } 

        }



    }
    

    Vector3 RandomSpotLightCirclePoint(Light spot)
    {
        float radius = Mathf.Tan(Mathf.Deg2Rad * (spot.spotAngle-7) / 2) * spot.range;
        Vector2 circle = Random.insideUnitCircle * radius;
        Vector3 target =  -transform.up *spot.range + spot.transform.rotation * new Vector3(circle.x, circle.y);
        return target;
    }


   
}

