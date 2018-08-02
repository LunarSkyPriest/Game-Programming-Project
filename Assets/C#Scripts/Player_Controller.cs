using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{

    public float playerSpeed = 10;  //allows us to be able to change speed in Unity
    public Vector2 jumpHeight;

    //Ground Check Variables for Double Jumping
    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;
    private bool grounded = false;
    private bool doubleJumped;

    // Update is called once per frame
    public float panSpeed = 20f;


    // Use this for initialization
    void Start()
    {
        
    }

    //Checked every second or so
    void FixedUpdate()
    {
       grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround); // Grounded check
    }


    void Update()
    {
        //------------------------------------------------
        //Movement
        Vector3 pos = transform.position;

        //Moving Left and Right and Down
        if (Input.GetKey("d"))
        {
            pos.x += 10 * Time.deltaTime;
        }
        if (Input.GetKey("a"))
        {
            pos.x -= 10 * Time.deltaTime;
        }
        if (Input.GetKey("s"))
        {
            if(grounded == false)
                pos.y -= 10 * Time.deltaTime;
        }


        transform.position = pos;
        transform.Translate(playerSpeed * Time.deltaTime, 0f, 0f);  //makes player run
        //-------------------------------------------------------------
        //Jumping and Double Jumping and Grounded Check
        if (grounded)
            doubleJumped = false;

        if (Input.GetKeyDown(KeyCode.W) && grounded)
        {
            GetComponent<Rigidbody2D>().AddForce(jumpHeight, ForceMode2D.Impulse);
        }

        if (Input.GetKeyDown(KeyCode.W) && !doubleJumped && !grounded)
        {
            GetComponent<Rigidbody2D>().AddForce(jumpHeight, ForceMode2D.Impulse);
            doubleJumped = true;
        }
        
    }
}


