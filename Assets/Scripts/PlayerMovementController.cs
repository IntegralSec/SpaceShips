using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
    public float speed = 10f;
    private Rigidbody2D rigidbody;

    bool flyingLeft;
    bool flyingRight;
    bool flyingUp;
    bool flyingDown;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // horizontal axis input
        float h = Input.GetAxis("Horizontal");
        
        // Vertical axis input
        float v = Input.GetAxis("Vertical");

        // Direction Vector
        Vector2 dir = new Vector2(h, v);

        rigidbody.velocity = dir.normalized * speed;

        if (h == 0)
        {
            flyingLeft = false;
            flyingRight = false;
            if (v > 0)
            {
                flyingUp = true;
                flyingDown = false;
            }
            else
            {
                // Default to flying down
                flyingUp = false;
                flyingDown = true;
            }
        }
        if (h < 0)
        {
            flyingLeft = true;
            flyingRight = false;
            flyingUp = false;
        }
        if (h > 0)
        {
            flyingLeft = false;
            flyingRight = true;
            flyingUp = false;
        }

        // Get the Animator component of the current object that this script is attached to
        animator.SetBool("isFlyingLeft", flyingLeft);
        animator.SetBool("isFlyingRight", flyingRight);
        animator.SetBool("isFlyingUp", flyingUp);
        animator.SetBool("isFlyingDown", flyingDown);

    }
}
