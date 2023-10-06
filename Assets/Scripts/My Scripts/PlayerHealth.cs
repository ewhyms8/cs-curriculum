using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    float timer;
    bool iframes;
    public int health;

    public float originalTimer = 1;

    private bool isRunning = false;

    private void Start()
    {
        timer = 1;
    }
    //Timer stop and start
    public void TimerStart()
    {
        if (isRunning)
        {
            timer -= Time.deltaTime;
            isRunning = true;
        }
    }
    void TimerStop()
    {
        if (timer < 0)
        {
            isRunning = false;
        }
    }
    //Health
    void ChangeHeath(int amount)
    {
        health += amount;
        if (health < 1)
        {
            Death();
        }
    }
    void Death()
    {
        health = 5;
        //reset health
        //transform.Translate() 
        //reset lvl
    }

    private void OnTriggerEnter(Collider Spikes)
    {
        if (gameObject.tag == "Spikes")
        {
            ChangeHeath(-2);
            isRunning = true;
            
        }
    }


}
