using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class landingAnim : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
        
        if (col.transform.tag == "Platform")
        {
            GetComponentInParent<Animator>().SetBool("land", true);
        }
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.transform.tag == "Platform")
        {
            GetComponentInParent<Animator>().SetBool("land", false);
        }
    }
}
