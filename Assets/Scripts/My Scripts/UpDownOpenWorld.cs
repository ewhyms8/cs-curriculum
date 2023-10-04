using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UpDownOpenWorld : MonoBehaviour
{
    float walkingSpeed;
    float xDirection;
    float yDirection;
    float xVector;
    float yVector;
    int coin;
    int health;
    public TextMeshProUGUI coinText;
    public TextMeshProUGUI healthText;

    void Start()
    {
        walkingSpeed = 5f;
        health = 5;
    }
    void Update()
    {
        //move up and down
        yDirection = Input.GetAxis("Vertical");
        yVector = yDirection * walkingSpeed * Time.deltaTime;
        xVector = xDirection * walkingSpeed * Time.deltaTime;
        transform.position = transform.position + new Vector3(0, yVector, 0);
        xDirection = Input.GetAxis("Horizontal");
        transform.position = transform.position + new Vector3(xVector, 0, 0);
        //healthText.text = ("Health: " + health);
        //coinText.text = ("Coins: " + coin);
    } 
    // when touch coin
    private void OnTriggerEnter2D(Collider2D other)
    {
        //if (other.gameOject.tag == "Coin")
        {
            CollectCoin(3);
            Destroy(gameObject);
            Debug.Log("Coins: " + coin);
        }
    }
    // for collect coin
    public void CollectCoin(int amount)
    {
        coin += amount;
    }


    //Health
    void ChangeHeath(int amount)
    {
        health += amount;
        if (health < 1)
        {
            Death();
        }
    }
    void Death()
    {
        health = 5;
        //reset health
        //transform.Translate() 
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
