﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startRoller : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        GetComponentInParent<Animator>().StopPlayback();
        GetComponentInParent<enemyWalk>().speed = 0;
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.transform.name == "Player")
        {
            GetComponentInParent<Animator>().StartPlayback();

            GetComponentInParent<enemyWalk>().speed = 2.5f;
        }
    }
}
