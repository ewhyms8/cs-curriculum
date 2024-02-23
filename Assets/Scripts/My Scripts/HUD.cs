using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HUD : MonoBehaviour
{
    public static HUD hud;
    public int coin;
    public int health;
    public int key;
    
    public CoinManager coinManager;
    public PlayerHealth playerHealth;

    public TextMeshProUGUI coinText;
    public TextMeshProUGUI healthText;
    public TextMeshProUGUI keyText;

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
        key = 0;
    }
    void Update()
    {
        healthText.text = ("Health: " + hud.health);
        coinText.text = ("Coins: " + hud.coin);
        keyText.text = ("Keys: " + hud.key);
    }
}