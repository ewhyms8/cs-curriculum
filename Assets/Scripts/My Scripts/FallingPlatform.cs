using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlatform : MonoBehaviour
{
    private float timeLeft = 5f;

    private bool fallingPlatform = true;
    void Start()
    {
        // if gameObject was null
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        //if player or enemy, set timer
        if (other.gameObject.CompareTag("Player"))
        {
            timeLeft -= Time.deltaTime;
            if (timeLeft <= 0)
            {
                fallingPlatform = false;
                Destroy(this.gameObject);
            }
        }
        //when time is up, platform = null
    }
}
