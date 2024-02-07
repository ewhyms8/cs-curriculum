using System;
using System.Collections.Generic;
using UnityEngine;


public class PFireball : MonoBehaviour
{
    public float speed = 8;
    private Vector3 target;
    
    void Start()
    {
        
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

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            target = GameObject.Find("MobileEnemy").transform.position;
        }

        if (other.gameObject.CompareTag("Turret"))
        {
            target = GameObject.Find("Turret").transform.position;
        }
    }
}
