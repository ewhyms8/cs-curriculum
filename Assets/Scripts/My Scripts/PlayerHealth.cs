using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Unity.VisualScripting;

public class PlayerHealth : MonoBehaviour
{
    public HUD hud;
    //bool iframes==false;
    private float timer;
    float originalTimer;

    void Start()
    {
        hud = GameObject.FindObjectOfType<HUD>();
        originalTimer = 1f;
        timer = originalTimer;
    }

    void Update()
    {
       // if (iframes)
        //{
            timer -= Time.deltaTime;
            if (timer < 0)
            {
              //  iframes = false;
                timer = originalTimer;
            }
        //}
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Spikes"))
        {
            //ChangeHealth(amount - 1);
            transform.position = transform.position + new Vector3(-1f, 1f, 0f);
        }
    }

    void ChangeHealth(int amount)
    {
        //if (!iframes)
        {
           // iframes = true;
            hud.health += amount;
            if (hud.health < 1)
            {
                Death();
            }
        }
    }

    void Death()
    {
        //SceneManager.LoadScene
    }


}
