using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemyDrop : MonoBehaviour
{
    public GameObject orcWithAxe;
    private bool timer;

    private GameObject coin;
    private GameObject healthPotion;
    private GameObject axe;
    private Vector3 enemyPos;
    private int orcHealth = 3;

    private Transform target;
    private float speed = 2;
    
    private int randNum;
    private float time = 2.0f;
    //private GameObject axe;
    // Start is called before the first frame update
    void Start()
    {
        orcWithAxe = GameObject.Find("MobileEnemy");
        coin = GameObject.Find("Coin");
        healthPotion = GameObject.Find("HealthPotion");
        //axe = GameObject.
        enemyPos = orcWithAxe.transform.position;
        target = null;
    }

    // Update is called once per frame
    void Update()
    {
        if (orcHealth <= 0)
        {
            OrcDeath();
        }

        if (target != null)
        {
            FollowPlayer();
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (timer = false)
            {
                Debug.Log("hit");
                orcHealth -= 1;
                Timer();
            }
        }
        if (other.gameObject.CompareTag("Bullet"))
        {
            orcHealth -= 1;
            Destroy(other.gameObject);
        }   
    }
// change to stay?
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            target = other.gameObject.transform;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        target = null;
    }

    void itemDrop()
    {
        randNum = Random.Range(0, 3);
        if (randNum == 1)
        {
            GameObject coinDrop;
            coinDrop = Instantiate(coin, enemyPos, Quaternion.identity);
        }
        if (randNum == 2)
        {
            GameObject potionDrop;
            potionDrop = Instantiate(healthPotion, enemyPos, Quaternion.identity);
        }
        if (randNum == 3)
        {
            GameObject axeDrop;
            axeDrop = Instantiate(axe, enemyPos, Quaternion.identity);
        }
    }

    void Timer()
    {
        if (time > 0)
        {
            timer = true;
        }
        timer = true;
        time -= Time.deltaTime;
        if (time <= 0)
        {
            timer = false;
        }
    }

    void FollowPlayer()
    {
        var stepp = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.position, stepp);
    }

    void OrcDeath()
    {
        // if last orc?
        // GameObject = lastDrop;
        // lastDrop = Instantiate(axe, enemyPos, Quaternion.identity);
        orcWithAxe.SetActive(false);
        itemDrop();
    }
}
