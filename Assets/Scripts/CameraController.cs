using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{
    public Transform sphere;



    void Update()

    {
        Vector3 vector = new Vector3(0f, 4f, 7f);

        Rigidbody rigidbody = sphere.GetComponent<Rigidbody>();
        transform.position = sphere.position + vector;
        float velocity = rigidbody.velocity.sqrMagnitude;
        transform.LookAt(sphere);
        vector = vector * (1f + velocity / 100f);
        Vector3 newPosition = sphere.position + vector;
        transform.position = Vector3.Lerp(transform.position, newPosition, Time.deltaTime * 2f);
    }
}
