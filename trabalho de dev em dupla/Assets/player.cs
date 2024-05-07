using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public GameObject bullet;

    public Transform foot;
    bool groundcheck;



    public int life = 3;
    public Rigidbody2D body;
    public float speed = 5, jumpStrength = 5, bulletspeed = 8;
    float horizontal;
    float vertical;
    float direction;



    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");

        body.velocity = new Vector2(horizontal * speed, body.velocity.y);
        groundcheck = Physics2D.OverlapCircle(foot.position, 0.05f);


        if (Input.GetButtonDown("Jump") && groundcheck)
        {
            body.AddForce(new Vector2(0, jumpStrength * 100));

        }

        if (Input.GetButtonDown("Fire1"))
        {
            GameObject temp = Instantiate(bullet, transform.position, transform.rotation);
            temp.GetComponent<Rigidbody2D>().velocity = new Vector2(bulletspeed, 0);
        }
        if (Input.GetButtonDown("Fire3"))
        {
            speed = speed * 2;
        }
    }

}


   
