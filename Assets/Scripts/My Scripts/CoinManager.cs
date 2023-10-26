using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
    public HUD hud;
    // when touch coin
    void Start()
    {
        hud = GameObject.FindObjectOfType<HUD>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            hud.coin = hud.coin + 1;
            Debug.Log("Coin : " + hud.coin);
            other.gameObject.SetActive(false);

        }
    }


}

