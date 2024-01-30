using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PFireball : MonoBehaviour
{
    private float speed = 8;
    private Vector3 target;
    
    void Start()
    {
        target = GameObject.Find("MobileEnemy").transform.position;
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
