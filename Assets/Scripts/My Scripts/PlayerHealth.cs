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
    public float originalTimer = 1f;
    private float xVector;
    private float yVector;
    private GameObject potion;
    
    public GameObject pFireball;
    private float timerShot = 2f;

    void Start()
    {
        hud = GameObject.FindObjectOfType<HUD>();
        timer = originalTimer;
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
        }
        if (other.gameObject.CompareTag("Bullet"))
        {
            ChangeHealth(hud.health -= 1);
            Destroy(other.gameObject);
        }   
        if (other.gameObject.CompareTag("Potion"))
        {
            ChangeHealth(hud.health += 2);
            potion.SetActive(false);
        }
        
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            if (Input.GetKeyDown(KeyCode.F))
            { 
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
        proj = Instantiate(pFireball, transform.position + new Vector3(0, 0.5f, 0), transform.rotation);
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
 Fix moving platform (w/ swtich) (done)
 Player shoot func & invincibility when casting
 Platformer level
 List of dead enemies
 List of coins
 List of potions & other interactive gameobjects
 Gain keys and interactive objects
 
*/