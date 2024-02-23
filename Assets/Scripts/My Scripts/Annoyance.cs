using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Annoyance : MonoBehaviour
{
    private int annoyingHealth = 2;

    public Vector3 target;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindObjectOfType<Fireball>().target;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
