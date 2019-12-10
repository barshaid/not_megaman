using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
 
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.transform.tag == "Enemy")
        {

            GetComponent<Animator>().SetBool("hurt", true);

            Time.timeScale = 0.25f;
        }
        
    }
}
