using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class EnemyDrop : MonoBehaviour
{
    public GameObject orcWithAxe;

    private GameObject coin;
    private GameObject healthPotion;
    private Vector3 enemyPos;

    private int randNum;

    private int orcHealth = 3;

    private float time = 2.0f;
    //private GameObject axe;
    // Start is called before the first frame update
    void Start()
    {
        orcWithAxe = GameObject.Find("OrcAxe");
        coin = GameObject.Find("Coin");
        healthPotion = GameObject.Find("HealthPotion");
        enemyPos = orcWithAxe.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (orcHealth <= 0)
        {
            orcWithAxe.SetActive(false);
            itemDrop();
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("hit");
            orcHealth -= 1;
            Timer();
        }
    }
    void itemDrop()
    {
        randNum = Random.Range(0, 3);
        if (randNum == 1)
        {
            Instantiate(coin, enemyPos, Quaternion.identity);
        }
        if (randNum == 2)
        {
            Instantiate(healthPotion, enemyPos, Quaternion.identity);
        }
        if (randNum == 3)
        {
            //Instantiate(axe, enemyPos, Quaternion.identity);
        }
    }

    void Timer()
    {
        time -= Time.deltaTime;
        if (time <= 0)
        {
            // can be hit
        }
    }
}
