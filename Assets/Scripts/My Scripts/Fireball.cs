using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Fireball : MonoBehaviour
{
    // Start is called before the first frame update
    
    public float speed = 2.0f;
    private GameObject player;
    private Vector3 playerpos;
    void Start()
    { 
        gameObject.SetActive(false);
        player = GameObject.Find("Player");
        playerpos = player.GetComponent<Transform>().position;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.active)
        {
            transform.Translate(playerpos.x, playerpos.y,0 );
        }
        
    }
}
