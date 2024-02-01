using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;
using UnityEditor.Search;

public class PlayerHealth : MonoBehaviour
{
    public HUD hud;
    bool iframes = false;
    private float timer;
    private float timerShot;
    float originalTimer;
    private float xVector;
    private float yVector;
    private GameObject potion;
    public GameObject PFireball;

    void Start()
    {
        hud = GameObject.FindObjectOfType<HUD>();
        originalTimer = 1f;
        timer = originalTimer;
        timerShot = 2f;
        potion = GameObject.Find("HealthPotion");
    }

    void Update()
    {
        if (iframes)
        {
            timer -= Time.deltaTime;
            if (timer < 0)
            {
                iframes = false;
                timer = originalTimer;
            }
            timerShot -= Time.deltaTime;
            if (timerShot < 0)
            {
                iframes = false;
                timerShot = 2;
            }
        }
        
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Spikes"))
        {
            ChangeHealth(hud.health -= 2);
            transform.position = transform.position + new Vector3(0.5f, -0.5f, 0f);
        }
        if (other.gameObject.CompareTag("Bullet"))
        {
            ChangeHealth(hud.health -= 1);
            Destroy(other.gameObject);
        }   
        
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Potion"))
        {
            ChangeHealth(hud.health += 2);
            potion.SetActive(false);
        }

        if (other.gameObject.CompareTag("Enemy"))
        {
            if (Input.GetKeyDown(KeyCode.F))
            { 
                print("f key hit");
                Shoot(); 
            }
        }
    }
    void ChangeHealth(int amount)
    {
        if (!iframes)
        {
            iframes = true;
            if (hud.health < 1)
            {
                Death();
            }
        }
    }

    void Shoot()
    {
        GameObject proj;
        proj = Instantiate(PFireball, transform.position + new Vector3(0, 0.5f, 0), transform.rotation);
    }
    void Death()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        print("You Died.");
        hud.health += 5;
        if (hud.coin >= 2)
        {
            hud.coin -= 2;
        }
    }
}

/*
 LIST WHAT TO DO
 Player side to side up and down (done)
 Player jump (done)
 Enemy move (done)
 Enemy drop or dead (done)
 Turret shoot func (done)
 Orc in contact with turret (done)
 HUD (done)
 Player shoot func & invincibility when casting
 Platformer level
 List of dead enemies
 List of coins
 List of potions & other interactive gameobjects
 
*/