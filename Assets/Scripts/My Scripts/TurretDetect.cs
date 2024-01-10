using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretDetect : MonoBehaviour
{
    public GameObject fireball;
    private float shootCooldown;
    public float cooldown;
    private Transform target;
    public float speed;
    void Start()
    {
        target = null;
        speed = 8;
    }
    // Update can go here if needed
    void Update()
    {
        shootCooldown -= Time.deltaTime;
        if (shootCooldown <= 0)
        {
            if (target != null)
            {
                print("shoot");
                //create projectile
                GameObject clone;
                clone = Instantiate(fireball, transform.position + new Vector3(0, 0.5f, 0), transform.rotation);
                //var step = speed * Time.deltaTime;
                //clone.transform.position = Vector3.MoveTowards(clone.transform.position, target.position, step);
                
                shootCooldown = cooldown;
            }
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            print("target acquired");
            target = other.gameObject.transform;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        print("target lost");
        target = null;
    }
}
