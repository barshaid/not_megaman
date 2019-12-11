using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startSentry : MonoBehaviour
{
    public bool detect = false;
    
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.transform.name == "Player")
        {
            detect = true;
            GetComponentInParent<Animator>().SetBool("detect", true);
        }
    }
   
 
}
