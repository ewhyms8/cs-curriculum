using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerHealth : MonoBehaviour
{
    float timer;
    bool iframes;
    int health;
    //public TextMeshPro ugui healthText;
    
    void ChangeHeath(int amount)
    {
        health += amount;
        if (health<1)
        {
            Death();
        }
    }
    void Death()
    {
        //reset health
        //reset lvl
    }

    private void OnTriggerEnter(Collider Spikes)
    {
        //hit obj
        {
            ChangeHeath(-2);
        }
    }

}
