using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public float fireRate;
    public GameObject projectileObject;
    private float nextFire;
    private Vector2 megabuster;

    public float NextFire { get => nextFire; set => nextFire = value; }

    public void shot()
    {
        megabuster = transform.GetChild(0).transform.position;
        if (Input.GetKey(KeyCode.LeftControl))
        {
            
            GetComponentInParent<Animator>().SetBool("shoot", true);
            
        } 
        else
            GetComponentInParent<Animator>().SetBool("shoot", false);

        if (Input.GetKey(KeyCode.LeftControl))
        {
            GetComponentInParent<Animator>().SetBool("shoot", true);
            if (Time.time > NextFire)
            {
                Instantiate(projectileObject, megabuster, Quaternion.Euler(Vector3.zero));
                

                NextFire = Time.time + 1 / fireRate;
            }
        }
    }
}
