using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public LayerMask ground;
    private BoxCollider2D boxCollider2d;
    private Rigidbody2D rb;
    public Transform groundCheck;
    public float radius;
    public bool isGrounded;
    public float speed;
    public Vector2 jumpHeight;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D> ();
        boxCollider2d = transform.GetComponent<BoxCollider2D>();
    }
    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, radius, ground);
        
        if (isGrounded && (Input.GetKey(KeyCode.W)))
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
        rb.AddForce(jumpHeight, ForceMode2D.Impulse);
    }
}
