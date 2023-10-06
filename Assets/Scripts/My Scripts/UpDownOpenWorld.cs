using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UpDownOpenWorld : MonoBehaviour
{
    float walkingSpeed;
    float xDirection;
    float yDirection;
    float xVector;
    float yVector;
    float ySpeed;

    void Start()
    {
        walkingSpeed = 5f;
        Scene scene = SceneManager.GetActiveScene();
        if (scene.name == "Overworld")
        {
           ySpeed = 5f;
        }
        if (scene.name == "Start")
        {
            ySpeed = 0f;
        }

    }
    void Update()
    {
        //move up and down
        yDirection = Input.GetAxis("Vertical");
        yVector = yDirection * walkingSpeed * Time.deltaTime;
        xVector = xDirection * walkingSpeed * Time.deltaTime;
        xDirection = Input.GetAxis("Horizontal");
        transform.position = transform.position + new Vector3(xVector, yVector, 0);

    }

    
       
    

}
