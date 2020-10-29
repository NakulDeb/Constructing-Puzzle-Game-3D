using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float force = 50f;
    public float speed = 2f;
    public float rotateSpeed = 50f;
    private bool move = true;
    AudioSource audioSource;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Keypad8))
        {
            //audioSource.Play();
            transform.Rotate(Vector3.right * rotateSpeed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.Keypad2))
        {
            transform.Rotate(Vector3.right * (rotateSpeed*-1) * Time.deltaTime);
        }
        else if (Input.GetKey("right"))
        {
            //audioSource.Play();
            transform.RotateAround(transform.position, Vector3.up, rotateSpeed * Time.deltaTime);
        }
        else if (Input.GetKey("left"))
        {
            transform.RotateAround(transform.position, Vector3.up, -rotateSpeed * Time.deltaTime);
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






        if (Input.GetKey("1"))
        {
            SceneManager.LoadScene("Menu1");
        }
        if (Input.GetKey("2"))
        {
            SceneManager.LoadScene("Menu2");
        }
        if (Input.GetKey("3"))
        {
            SceneManager.LoadScene("Menu3");
        }
        if (Input.GetKey("4"))
        {
            SceneManager.LoadScene("Menu4");
        }
        if (Input.GetKey("5"))
        {
            SceneManager.LoadScene("Menu5");
        }
        if (Input.GetKey("6"))
        {
            SceneManager.LoadScene("Menu6");
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