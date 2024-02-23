using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossScript : MonoBehaviour {
    
    public GameObject fireball;
    private float shootCooldown;
    public float cooldown;
    private Transform target = null;
    private float bossHealth = 15;
    void Update()
    {
        shootCooldown -= Time.deltaTime;
        if (shootCooldown <= 0)
        {
            if (target != null)
            {
                GameObject clone;
                clone = Instantiate(fireball, transform.position + new Vector3(2f, 0, 0), transform.rotation);
                
                shootCooldown = cooldown;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("PlayerBullet"))
        {
            bossHealth -= 1;
        }
    }
    
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            target = other.gameObject.transform;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            print("target lost");
            target = null;
        }
    }
}
