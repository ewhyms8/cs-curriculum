using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HUD : MonoBehaviour
{
    public CoinManager coinManager;
    public PlayerHealth playerHealth;

    public TextMeshProUGUI coinText;
    public TextMeshProUGUI healthText;

    public int coin;
    public int health;
    
    void Update()
    {
        healthText.text = ("Health: " + health);
        //healthText.text = PlayerHealth.health.ToString();

        coinText.text = ("Coins: " + coin);
        //coinText.text = CoinManager.coin();
        
    }
}
