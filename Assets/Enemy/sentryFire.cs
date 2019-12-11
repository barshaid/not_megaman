using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sentryFire : MonoBehaviour
{
    public GameObject Projectile;
    public float fireRate = 5;
    
 

    private IEnumerator coroutine;

    
    private void Start()
    {
        
        coroutine = shot();
        
        
    }

   

    IEnumerator shot()
    {
        while (true)
        {
           
                float timer = Random.Range(0f, fireRate);
                yield return new WaitForSeconds(timer);
                float shootingTimer = 2f;
                GetComponentInParent<Animator>().Play("SentryFire");
                Instantiate(Projectile, transform.position, Quaternion.identity);

                yield return new WaitForSeconds(shootingTimer);
        }
        
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.transform.name == "Player")
        {
            StartCoroutine(coroutine);
            GetComponentInParent<Animator>().SetBool("detect", true);
        }
    }
}
   

