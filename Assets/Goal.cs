using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public GameObject ClearText;
    public GameObject NextLevel;
    public AudioSource audioSource;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("ÉSÅ[Éã!");

        ClearText.SetActive(true);
        NextLevel.SetActive(true);
        audioSource.Play();
    }

}
