using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingUp : MonoBehaviour
{
    private float speed = 2;
    private Vector3 target;
    public PlatformerScript platformerScript;

    void Start()
    {
        platformerScript = GameObject.FindObjectOfType<PlatformerScript>();
    }
    void Update()
    {
        var step = speed * Time.deltaTime;
        if (platformerScript.Switch == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, target, step);
        }
        if (gameObject.transform.position.y >= 4.46f)
        {
            target = new Vector3(-0.993f, -2.94f, 0);
        }

        if (gameObject.transform.position.y <= -2.84f)
        {
            target = new Vector3(-0.993f, 4.5f, 0);
        }
    }
    
}
