using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootStepsSound : MonoBehaviour
{
    public AudioSource audioSource;
    public float carwait = 0.5f;
    void Start()
    {
        InvokeRepeating("PlaySound", 0.001f, carwait);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PlaySound()
    {
        if (Input.GetKey("right") || Input.GetKey("left") || Input.GetKey("up") || Input.GetKey("down"))
        {
            audioSource.Play();
        }
    }
}
