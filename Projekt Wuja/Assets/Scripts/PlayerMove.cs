using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    public float walkSpeed = 2.0f;
    public float runSpeed = 4.0f;
    public float speed = 4.0f;
    void Update()
    {

        if (Input.GetKey(KeyCode.RightArrow))
        {

            if (Input.GetKey(KeyCode.LeftShift))
            {
                transform.position += Vector3.right * runSpeed * Time.deltaTime;
            }
            else
            {
                transform.position += Vector3.right * walkSpeed * Time.deltaTime;
            }
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {

            if (Input.GetKey(KeyCode.LeftShift))
            {
                transform.position += Vector3.left * runSpeed * Time.deltaTime;
            }
            else
            {
                transform.position += Vector3.left * walkSpeed * Time.deltaTime;
            }
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += Vector3.up * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += Vector3.down * speed * Time.deltaTime;
        }
    }
}