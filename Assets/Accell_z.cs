using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Accell_z : MonoBehaviour
{
    public AudioSource audioSource;
    public float power = 3;
    private void OnTriggerStay(Collider other)
    {
        Rigidbody r = other.GetComponent<Rigidbody>();
        if (r != null)
        {
            r.AddForce(new Vector3(0, 0, 1) * power);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        audioSource.Play();
    }
}
