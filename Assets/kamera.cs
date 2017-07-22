using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kamera : MonoBehaviour
{
    public Transform sphere;

    void Update()
    {
        Rigidbody rigidbody = sphere.GetComponent<Rigidbody>();

        Vector3 vector = (new Vector3(-5, 2, 0));
        float velocity = rigidbody.velocity.sqrMagnitude;
        vector = vector * (1f+velocity/300f);

        Vector3 newPosition = sphere.position + vector;

        transform.position = Vector3.Lerp(transform.position, newPosition, Time.deltaTime*2f);
        transform.LookAt(sphere);
    }
}   
