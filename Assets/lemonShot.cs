using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lemonShot : MonoBehaviour
{

    public float speed = 5.0f   ;
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }
}
