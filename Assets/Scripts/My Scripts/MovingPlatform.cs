using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class MovingPlatform : MonoBehaviour
{
    private float speed = 2;
    private Vector3 target;
    void Update()
    {
        var step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target, step);
        
        if (gameObject.transform.position.x <= 10.13f)
        {
            target = new Vector3(15.91f, -0.5f, 0);
        }

        if (gameObject.transform.position.x >= 14.91f)
        {
            target = new Vector3(9.13f, -0.5f, 0);
        }
    }
}
