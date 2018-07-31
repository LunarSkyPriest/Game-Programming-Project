using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderPushBall : MonoBehaviour
{
    private Rigidbody2D rb2d;
    private Vector2 vel;

    // Use this for initialization
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();

    }

    //Rotation of the Ball
    void FixedUpdate()
    {
        transform.Rotate(0, 0, 5);
    }

    //Collisions
    void OnCollisionEnter2D(Collision2D coll)
    {

        if (coll.gameObject.tag == "Player")
        {
            if(Random.Range(0, 2) == 1)
            {
                vel.x = rb2d.velocity.x - 4;
                vel.y = (rb2d.velocity.y + 8);
            }
            else
            {
                vel.x = rb2d.velocity.x + 4;
                vel.y = (rb2d.velocity.y + 8);
            }
            rb2d.velocity = vel;
        }

        if (coll.gameObject.tag == "Wall")
        {
            vel.x = rb2d.velocity.x;
            vel.y = (rb2d.velocity.y);
            rb2d.velocity = vel;
        }
    }

}
