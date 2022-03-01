using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveStraightController : MonoBehaviour
{
    public Vector2 velocity;
    Rigidbody2D rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        // Get the RigidBody from the game object that holds this script
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // FixedUpdate is better for physics
    void FixedUpdate()
    {
        rigidbody.velocity = velocity;
    }
}
