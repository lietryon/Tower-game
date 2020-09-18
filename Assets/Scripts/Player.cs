using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed;
    public float jumpVelocity;

    Rigidbody2D rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D> ();
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            Jump();
        }

        

        // Move the character
        transform.Translate(Input.GetAxis("Horizontal")* speed * Time.deltaTime, 0f, 0f);

        // Flip the character
        Vector3 characterScale = transform.localScale;
        if (Input.GetAxis("Horizontal") < 0)
        {
            characterScale.x = -1;
        }
        if (Input.GetAxis("Horizontal") > 0)
        {
            characterScale.x = 1;
        }
        transform.localScale = characterScale;
    }

    void Jump()
    {
        rb.velocity += Vector2.up * jumpVelocity;
    }
}
