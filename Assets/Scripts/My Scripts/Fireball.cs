using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    // Start is called before the first frame update
    
    public float speed = 2.0f;
    void Start()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
        // player comes within distance of turret
        //if (turret detects player)
        //{

            // Turret bullet is set active
            gameObject.SetActive(true);
            // Turret bullet goes to player poition on entering feild
            // go to player.position
            // Bullet set active false at point where player was
            gameObject.SetActive(false);
       // }
    }
}
