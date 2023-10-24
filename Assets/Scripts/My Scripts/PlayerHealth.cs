using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class PlayerHealth : MonoBehaviour
{
    public HUD hud;
    bool iframes = false;
    private float timer;
    float originalTimer;
    private float xVector;
    private float yVector;

    void Start()
    {
        hud = GameObject.FindObjectOfType<HUD>();
        originalTimer = 1f;
        timer = originalTimer;
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
            ChangeHealth(hud.health - 1); 
            transform.position = transform.position + new Vector3(-1f, 1f, 0f);
        }
    }
    // private void OnTriggerEnter2D(Collision2D other)
    // if(other.gameObject.CompareTag("Potion"))
    // ChangeHealth(hud.health + 2);

    //private void OnCollisionEnter2D(Collision2D other)
    // if other.gameObject.CompareTag("Bullet"))
    // ChangeHealth(hud.health - 1);
    
    void ChangeHealth(int amount)
    {
        if (!iframes)
        {
            iframes = true;
            hud.health += amount;
            if (hud.health < 1)
            {
                Death();
            }
        }
        Debug.Log("Health: " + hud.health);
    }

    void Death()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        print("You Died.");
    }


}
