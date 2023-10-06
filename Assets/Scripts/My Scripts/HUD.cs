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
    
    void Update()
    {
        //healthText.text = ("Health: " + health);
        //coinText.text = ("Coins: " + coin);
        //coinText.text = CoinManager.coin.ToString();
        //healthText.text = PlayerHealth.health.ToString();
    }
}
