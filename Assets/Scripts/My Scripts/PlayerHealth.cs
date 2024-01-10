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
    float originalTimer;
    private float xVector;
    private float yVector;
    private GameObject potion;

    void Start()
    {
        hud = GameObject.FindObjectOfType<HUD>();
        originalTimer = 1f;
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
            other.gameObject.SetActive(false);
            transform.position = transform.position + new Vector3(0.2f, -0.2f, 0f);
            Debug.Log("Health " + hud.health);
        }   
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Potion"))
        {
            ChangeHealth(hud.health += 2);
            potion.SetActive(false);
        }

        if (other.gameObject.CompareTag("Enemy"))
        {
            //Shoot()
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
    void Death()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        print("You Died.");
        hud.health += 5;
        hud.coin -= 2;
    }
}
