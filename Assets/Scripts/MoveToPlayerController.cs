using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToPlayerController : MonoBehaviour
{
    public float speed = 1;
    // Start is called before the first frame update
    void Start()
    {
        GameObject playerObject = GameObject.FindWithTag("Player");

        // Check if the player still exists
        if(playerObject != null)
        {
            // Transform.position is the position of the gameobject that holds this script (the bullet, or monster)
            Vector2 playerPosition = (playerObject.transform.position - transform.position).normalized;
            GetComponent<Rigidbody2D>().velocity = playerPosition * speed;
        }

    }

}
