using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class diagonalShot : MonoBehaviour
{

    public float speed = 4;

    void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);
       
         transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}

