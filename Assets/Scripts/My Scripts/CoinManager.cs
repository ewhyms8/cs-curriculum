using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
    public int coin;
    // when touch coin

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            CollectCoin(3);
            Debug.Log("Coins: " + coin);
            gameObject.SetActive(false);
        }
    }
    // for collect coin
    public void CollectCoin(int amount)
    {
     coin += amount;
    }


}
//done & fixed
