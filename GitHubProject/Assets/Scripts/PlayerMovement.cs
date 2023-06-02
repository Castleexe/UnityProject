using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D body;

    float horizontal;
    float vertical;
    float moveLimiter = 0.7f;

    public float runSpeed = 6.9f;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Gives a value between -1 and 1
        horizontal = Input.GetAxisRaw("Horizontal"); // -1 is left
        vertical = Input.GetAxisRaw("Vertical"); // -1 is down
    }

    void FixedUpdate()
    {
        if (horizontal != 0 && vertical != 0) // Check for diagonal movement
        {
            // limit movement speed diagonally, so you move at 70% speed
            horizontal *= moveLimiter;
            vertical *= moveLimiter;
        }  

        if(vertical > 0)
        {
            Debug.Log("Up");
        }
        else if(vertical < 0)
        {
            Debug.Log("Down");
        }
        else if(horizontal > 0)
        {
            Debug.Log("right");
        }
        else if(horizontal < 0)
        {
            Debug.Log("Left");
        }
        else
        {
            Debug.Log("Idle");
        }
            

        body.velocity = new Vector2(horizontal * runSpeed, vertical * runSpeed);
    }
}
