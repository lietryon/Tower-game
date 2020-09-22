using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] private LayerMask platformsLayerMask;
    private BoxCollider2D boxCollider2d;
    private Rigidbody2D rb;
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
        if (IsGrounded() && (Input.GetKey(KeyCode.W)))
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
        GetComponent<Rigidbody2D>().AddForce(jumpHeight, ForceMode2D.Impulse);


    }

    bool IsGrounded()
    {
        RaycastHit2D raycastHit2d = Physics2D.BoxCast(boxCollider2d.bounds.center, boxCollider2d.bounds.size, 0f, Vector2.down, .1f, platformsLayerMask);
        return raycastHit2d.collider != null;
    }
}
