using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HUD : MonoBehaviour
{
    public static HUD hud;
    public int coin;
    public int health;
    
    public CoinManager coinManager;
    public PlayerHealth playerHealth;

    public TMP_Text coinText;
    public TMP_Text healthText;

    void Awake()
    {
        if (hud != null && hud != this)
        {
            Destroy(gameObject);
        }
        else
        {
            hud = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    void Start()
    {
        coin = 0;
        health = 5;
    }
    void Update()
    {
        
        healthText.text = ("Health: " + hud.health);
        coinText.text = ("Coins: " + hud.coin);
    }
}
// set coin amount and health amount where???