using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretDetect : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject fireball;
    void Start()
    {
        fireball = GameObject.Find("Fireball");
        Instantiate(fireball, new Vector3(9.897f, 13.453f, 0f), Quaternion.identity);
        
    }

    // Update is called once per frame
    void Update()
    {
     
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player found");
            if (fireball == null)
            {
                Debug.Log("It isn't being called to");
            }
            if (fireball != null)
            {
                Debug.Log("fireball is real");
                fireball.SetActive(true);
            }
        }
    }
}
