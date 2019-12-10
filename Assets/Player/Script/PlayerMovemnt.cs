using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovemnt : MonoBehaviour
{
    private bool grounded = false;
    public float hSpeed = 3.0f;
    public float jForce = 3.0f;
    void Update()
    {
        Vector3 myScale = transform.localScale;
        bool rotate = false;
        

        if (Input.GetAxis("Horizontal") < 0 && myScale.x > 0)
        {
            rotate = true;
            
        }
        else if (Input.GetAxis("Horizontal") > 0 && myScale.x < 0)
        {
            rotate = true;
        }

        if (Input.GetKeyDown(KeyCode.Space) && grounded)
        {
            GetComponent<Rigidbody2D>().AddForce(transform.up * jForce, ForceMode2D.Impulse);
            GetComponent<Animator>().SetBool("jump", true);
        }
        


        if (rotate)
        {
            myScale.x = myScale.x * -1;
            transform.localScale = myScale;
        }
        if (Input.GetAxis("Horizontal") == 0)
        {
            GetComponent<Animator>().SetFloat("speed", 0);
        }

        GetComponent<Animator>().SetFloat("speed", Mathf.Abs(Input.GetAxis("Horizontal")));
        GetComponent<Rigidbody2D>().velocity = new Vector2(Input.GetAxis("Horizontal") * hSpeed, GetComponent<Rigidbody2D>().velocity.y);
    }


    private void OnCollisionExit2D(Collision2D col)
    {
        if (col.transform.tag == "Platform")
        {
            grounded = false;
        }
        

    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.transform.tag == "Platform")
        {
            grounded = true;
            GetComponent<Animator>().SetBool("jump", false);
        }


    }
}
 