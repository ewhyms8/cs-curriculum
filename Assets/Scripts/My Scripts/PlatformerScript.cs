using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformerScript : MonoBehaviour
{
    // Start is called before the first frame update
    private float xDirection;
    private float xVector;
    private float walkingSpeed = 3f;
    //jump func
    private Rigidbody2D rb2D;
    public Vector3 jump;
    public float jumpForce = 3f;

    private float jumpsLeft;
    private bool canJump;
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        jump = new Vector3(0, 2f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        xVector = xDirection * walkingSpeed * Time.deltaTime;
        xDirection = Input.GetAxis("Horizontal");
        transform.position = transform.position + new Vector3(xVector, 0, 0);
        if (jumpsLeft <= 0)
        {
            canJump = false;
        }
        
        //jump func
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (canJump = true)
            {
                //jump
                rb2D.AddForce(jump * jumpForce, ForceMode2D.Impulse);
                jumpsLeft -= 1;
            }

            if (canJump = false)
            {
                print("not jumping");
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Floor"))
        {
            print("jumps left: " + jumpsLeft);
            jumpsLeft = 2;
        }
    }
}
