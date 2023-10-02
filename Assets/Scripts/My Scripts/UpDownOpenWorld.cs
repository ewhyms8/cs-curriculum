using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpDownOpenWorld : MonoBehaviour
{
    float walkingSpeed;
    float xDirection;
    float yDirection;
    float xVector;
    // Start is called before the first frame update
    void Start()
    {
        walkingSpeed = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        //move up and down
        //yDirection = Input.GetAxis("Verticle");
        xVector = yDirection * walkingSpeed * Time.deltaTime;
        //transform.position = transform.position + new Vector3(0, xVector, 0);
        xDirection = Input.GetAxis("Horizontal");
        transform.position = transform.position + new Vector3(xVector, 0, 0);
    }
}
