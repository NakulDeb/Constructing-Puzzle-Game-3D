using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public Animator _animator;
    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Debug.Log("OK");
           // Animator anim = other.GetComponent<Animator>();
            if (Input.GetKeyDown(KeyCode.E))
            {
                _animator.SetBool("OpenClose", true);
            }
            
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            _animator.SetBool("OpenClose", true);
        }
    }
}
