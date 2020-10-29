using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectController : MonoBehaviour
{
    public float force = 50f;
    public float speed = 3f;
    public float rotateSpeed = 100f;
    private bool move = true;

    public float delta = 1.5f; 
    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("8"))
        {
            //audioSource.Play();
            transform.Rotate(Vector3.right * rotateSpeed * Time.deltaTime);
        }
        else if (Input.GetKey("2"))
        {
            transform.Rotate(Vector3.right * (rotateSpeed*-1) * Time.deltaTime);
        }
        else if (Input.GetKey("right"))
        {
            Vector3 moveDir = Vector3.zero;
            moveDir.x = Input.GetAxis("Horizontal");
            transform.position += moveDir * speed * Time.deltaTime;
        }
        else if (Input.GetKey("left"))
        {
            Vector3 moveDir = Vector3.zero;
            moveDir.x = Input.GetAxis("Horizontal");
            transform.position += moveDir * speed * Time.deltaTime;
        }

        if (Input.GetKey("up") && move)
        {
            transform.position += transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey("down"))
        {
            transform.position -= transform.forward * speed * Time.deltaTime;
            move = true;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.name == "Ground")
        {
            move = false;
            Debug.Log("Hit");
        }
    }
}