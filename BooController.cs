using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BooController : MonoBehaviour
{

    public Rigidbody2D rb;
    public SpriteRenderer sr;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 velocity = rb.velocity;

        //Moving left and right
        velocity.x = Input.GetAxis("Horizontal") * 5;

        //Jumping
        if(Input.GetButtonDown("Jump")) {
            velocity.y = 12;
        }

        //Face the right way
        if(velocity.x != 0) {
            if(Mathf.Sign(velocity.x) == 1) {
                sr.flipX = false;
            }
            else {
                sr.flipX = true;
            }
        }

        rb.velocity = velocity;
    }
}
