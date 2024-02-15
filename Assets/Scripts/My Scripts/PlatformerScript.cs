using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformerScript : MonoBehaviour
{
    public HUD hud;
    // Start is called before the first frame update
    private float xDirection;
    private float xVector;
    private float walkingSpeed = 3f;
    //jump func
    private Rigidbody2D rb2D;
    public Vector3 jump;
    public float jumpForce = 3f;

    private float jumpsLeft = 2;
    private bool canJump;
    
    public bool Switch = false;
    void Start()
    {
        hud = GameObject.FindObjectOfType<HUD>();
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
        else
        {
            canJump = true;
        }
        
        //jump func
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (canJump == true)
            {
                rb2D.AddForce(jump * jumpForce, ForceMode2D.Impulse);
                jumpsLeft -= 1;
            }

            if (canJump == false)
            {
                print("not jumping");
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Floor"))
        {
            if (jumpsLeft == 1)
            {
                jumpsLeft += 1;
            }
            else if(jumpsLeft == 0)
            {
                jumpsLeft += 2;
            }
        }
        if (other.gameObject.CompareTag("Switch"))
        {
            Switch = true;
        }
    }
}
