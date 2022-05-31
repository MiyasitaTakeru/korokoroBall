using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Accell : MonoBehaviour
{
    public AudioSource audioSource;
    public float power = 3;
    private void OnTriggerStay(Collider other)
    {
        Rigidbody r =other.GetComponent<Rigidbody>();
        if(r!= null)
        {
            r.AddForce(new Vector3(1,0,0)*power);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        audioSource.Play();
    }
}
