using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovent : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed = 10;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();        
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right*(Time.deltaTime*speed),Space.Self);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.left * (Time.deltaTime * speed), Space.Self);
        }
        else
        {
           transform.Translate(Vector2.zero, Space.Self);

        }

    }
}
