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
    //private GameObject player;

    void Start()
    {
        //player = GameObject.Find("Player");
        walkingSpeed = 3f;
        Scene scene = SceneManager.GetActiveScene();
        if (scene.name == "Overworld")
        {
           ySpeed = 1f;
        }
        if (scene.name == "Start")
        {
            ySpeed = 0f;
        }

    }
    void Update()
    {
        //Debug.Log("Player position" + player.transform.position);
        //move up and down
        yDirection = Input.GetAxis("Vertical");
        yVector = ySpeed *yDirection * walkingSpeed * Time.deltaTime;
        xVector = xDirection * walkingSpeed * Time.deltaTime;
        xDirection = Input.GetAxis("Horizontal");
        transform.position = transform.position + new Vector3(xVector, yVector, 0);
        
        
        //if player hits key
        // gameObject.Bullet.SetActive
        // copy over Fireball from turret
    }

    
       
    

}
