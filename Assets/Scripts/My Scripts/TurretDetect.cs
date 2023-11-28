using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretDetect : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject fireball;
    private float speed = 2;
    private GameObject player;
    private Vector3 playerpos;
    void Start()
    {
        Instantiate(fireball, new Vector3(9.897f, 13.453f, 0f), Quaternion.identity);
        fireball.SetActive(false);
        player = GameObject.Find("Player");
        playerpos = player.GetComponent<Transform>().position;
    }
    // Update can go here if needed
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            fireball.SetActive(true);
            fireball.transform.position = Vector3.MoveTowards(transform.position, playerpos, speed * Time.deltaTime);
        }
    }
}
