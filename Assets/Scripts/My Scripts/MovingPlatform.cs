using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MovingPlatform : MonoBehaviour
{
    private Rigidbody2D rb2d;
    private float speed = 2;
    private bool direction = false;

    private Vector3 endPosition = new Vector3(15.41f, -0.52f, 0);
    private Vector3 startPosition = new Vector3(9.54f, -0.52f, 0);
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        transform.position = startPosition;
        
    }

    void Update()
    {
        if (rb2d.position.x >= 9.54f)
        {
            direction = false;
            transform.Translate(Vector3.right * Time.deltaTime * speed);
            
        }
        if (rb2d.position.x <= 15.41f)
        {
            direction = true;
            transform.Translate(Vector3.left * Time.deltaTime * speed);
            //print("at end");
        }
        else 
        {
            if (direction = false)
            {
                transform.Translate(Vector3.right * Time.deltaTime * speed);
            }
            if (direction = true)
            {
                transform.Translate(Vector3.left * Time.deltaTime * speed);
            }
        }
    }
}
