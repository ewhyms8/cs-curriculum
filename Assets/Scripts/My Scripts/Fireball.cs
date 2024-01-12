using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Fireball : MonoBehaviour
{
    public float speed;
    private Vector3 target;
    
    void Start()
    {
        target = GameObject.Find("Player").transform.position;
        //target = GameObject.FindObjectOfType<PlayerMovement>().gameObject.transform.position;
        speed = 8;
        
    }

    // Update is called once per frame
    void Update()
    {
        var step = speed * Time.deltaTime;
        
        transform.position = Vector3.MoveTowards(transform.position, target, step);

        if (Vector3.Distance(transform.position, target) < 0.001f)
        {
            Destroy(gameObject, 0.1f);
        }
    }
}
