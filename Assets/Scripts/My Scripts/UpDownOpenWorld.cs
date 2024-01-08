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
    
    private GameObject pfireball;
    private GameObject enemy;
    private Vector3 enemypos;
    //private float speed = 2;

    void Start()
    {
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
        //enemy = GameObject.FindGameObjectsWithTag("Enemy");
        //enemypos = enemy.GetComponent<Transform>().position;
    }
    void Update()
    {
        yDirection = Input.GetAxis("Vertical");
        yVector = ySpeed *yDirection * walkingSpeed * Time.deltaTime;
        xVector = xDirection * walkingSpeed * Time.deltaTime;
        xDirection = Input.GetAxis("Horizontal");
        transform.position = transform.position + new Vector3(xVector, yVector, 0);
        
        //if (Input.GetKeyDown(KeyCode.F))
        //{
           // pfireball.SetActive(true);
            //pfireball.transform.position = Vector3.MoveTowards(transform.position, enemypos, speed);
       // }
    }
    

}
