using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killPlayer : MonoBehaviour
{

    public Vector3 respawnPoint;
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player") // if a player hits the collider of this obstacle
        {
            collision.gameObject.transform.position = respawnPoint;
        }
    }
}
