using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class cenadalaura : MonoBehaviour
{   public Rigidbody2D body;
    public float speed = 5, jumpStrength = 5, bulletspeed = 8;
    float horizontal;
    




    // Start is called before the first frame update
    void Start()
    {
        horizontal = Input.GetAxisRaw("Horizontal");

        body.velocity = new Vector2(horizontal * speed, body.velocity.y);
        groundcheck = Physics2D.OverlapCircle(foot.position, 0.05f);

    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
