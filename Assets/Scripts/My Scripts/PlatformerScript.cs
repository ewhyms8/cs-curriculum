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
    public float jumpForce = 2f;
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
        
        //jump func
        if (Input.GetKeyDown(KeyCode.Space))
        {
            RaycastHit2D hit = Physics2D.Raycast(transform.position, -Vector2.up, 0.5f);
            if (hit.collider != null)
            {
                //jump
                rb2D.AddForce(jump * jumpForce, ForceMode2D.Impulse);
            }
                
        }
    }

}
