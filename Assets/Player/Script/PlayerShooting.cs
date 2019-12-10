using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public float fireRate;
    public GameObject projectileObject;
    public float nextFire;

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftControl))
        {
            
            GetComponentInParent<Animator>().SetBool("shoot", true);
            
        } 
        else
            GetComponentInParent<Animator>().SetBool("shoot", false);

        if (Input.GetKey(KeyCode.LeftControl))
        {
            GetComponentInParent<Animator>().SetBool("shoot", true);
            if (Time.time > nextFire)
            {
                Instantiate(projectileObject, transform.position, Quaternion.Euler(Vector3.zero));
                

                nextFire = Time.time + 1 / fireRate;
            }
        }
    }
}
