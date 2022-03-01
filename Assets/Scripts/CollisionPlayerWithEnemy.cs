using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionPlayerWithEnemy : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Monster")
        {
            // Destroy the Enemy
            Destroy(collision.gameObject);
            // Destroy the player
            Destroy(gameObject);
        }
    }

    // this function is called once this game object is destroyed
    private void OnDisable()
    {
        SceneManager.LoadSceneAsync(0);
    }
}
