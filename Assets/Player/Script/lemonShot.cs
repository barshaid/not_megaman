using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lemonShot : MonoBehaviour
{

    public float speed = 1.0f;
    bool direction;
    void Start()
    {
        if (GameObject.Find("Player").transform.localScale.x > 0)
        {
            direction = true;
        }
        else
            direction = false;
    }


    void Update()
    {
        if(direction)
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        else
            transform.Translate(Vector2.left * speed * Time.deltaTime);
    }
}
