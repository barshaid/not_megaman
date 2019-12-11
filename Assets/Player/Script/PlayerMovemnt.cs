using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovemnt : MonoBehaviour
{
    private bool start = false;
    public float hSpeed = 3.0f;
    public float jForce = 3.0f;
    public LayerMask groundLayer;


    bool isGrounded()
    {

        Vector2 position = transform.position;
        Vector2 direction = Vector2.down;
        float distance = 0.5f;

   
        
        RaycastHit2D hit = Physics2D.Raycast(position, direction, distance, groundLayer);
        if (hit.collider != null)
        {
            return true;
        }

        return false;
    }

    void Update()
    {
        if (start)
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

            if (Input.GetKeyDown(KeyCode.Space) && isGrounded())
            {
                GetComponent<Rigidbody2D>().AddForce(transform.up * jForce, ForceMode2D.Impulse);
                GetComponent<Animator>().SetBool("jump", true);
            }
            GetComponent<Animator>().SetBool("land", isGrounded());



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

            GetComponent<PlayerShooting>().shot();

            if (!GameObject.FindGameObjectWithTag("Enemy"))
            {
                Time.timeScale = 0.5f;
                GetComponent<Animator>().SetBool("win", true);
                start = false;

            }
        }
    }


    
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.transform.tag == "Platform")
        {
            start = true;
            GetComponent<Animator>().SetBool("jump", false);
        }


    }
}
 