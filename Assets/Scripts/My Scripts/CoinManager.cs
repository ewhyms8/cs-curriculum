using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
    public int coin;
    void Start()
    {
        Debug.Log("This works");
    }
    // when touch coin

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Coin")
        {
            CollectCoin(3);
            other.gameObject.SetActive(false);
            Debug.Log("Coins: " + coin);
        }
    }
    // for collect coin
    public void CollectCoin(int amount)
    {
        coin += amount;
    }

    
}
