using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    // Start is called before the first frame update
    float timer;
    public float originalTimer = 1;
    void Start()
    {
        timer = originalTimer;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer<0)
        {
            //reset timer
            timer = 1f;
            //turn off iframe
        }
    }
}
