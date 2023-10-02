using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    int coin;
    //public TextMeshPro ugui coinText; 
    // Start is called before the first frame update
    void CollectCoin(int amount)
    {
        coin += amount;
    }
    private void OnTriggerEnter(Collider Coin)
    {
        //run into coin
        //set active here
        {
            CollectCoin(1);
        }
    }
}
