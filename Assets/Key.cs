using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public AudioSource audioSource;
    public GameObject door;
    public float timer = 0;
    public int flag = 0;

    private void OnTriggerEnter(Collider other)
    {
        timer = 30;
        flag = 1;
        audioSource.Play();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (flag == 1)
        {
            timer -= 1;
            if(timer <= 0)
            {
                Destroy(door);
                Destroy(gameObject);
                timer = 0;
                flag = 0;
            }
        }
    }
}
