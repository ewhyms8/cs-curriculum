using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBullet : MonoBehaviour
{
    private float speed = 8;
    private Vector3 target;
    void Start()
    {
        if (target != null)
        {
            target = GameObject.Find("Player").transform.position;
            print("target position: " + target);
        }
        else
        {
            print("no position found, target = null");
        }
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
