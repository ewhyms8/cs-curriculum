using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalPlat2 : MonoBehaviour
{
    private float speed = 2;
    private Vector3 target;
    public PlatformerScript platformerScript;

    void Start()
    {
        platformerScript = GameObject.FindObjectOfType<PlatformerScript>();
    }
    void Update()
    {
        var step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target, step);
        if (gameObject.transform.position.y >= 13.1f)
        {
            target = new Vector3(26.5f, 1.491f, 0);
        }

        if (gameObject.transform.position.y <= 1.5f)
        {
            target = new Vector3(26.5f, 13.13f, 0);
        }
    }
}
