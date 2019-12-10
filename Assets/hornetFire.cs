using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hornetFire : MonoBehaviour
{
    public GameObject Projectile;
    public float fireRate = 5;
    
    private Vector2 gun;
    private IEnumerator coroutine;

    private void Start()
    {
        coroutine = shot();
        StartCoroutine(coroutine);
        gun = transform.GetChild(0).transform.position;
    }

    IEnumerator shot()
    {
        while (true)
        {
            float timer = Random.Range(0f, fireRate);
            yield return new WaitForSeconds(timer);
            float shootingTimer = 2f;
            GetComponentInParent<Animator>().Play("HornetFire");
            Instantiate(Projectile, gun, Quaternion.identity);

            

            yield return new WaitForSeconds(shootingTimer);
            
        }
    }
}
   