using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour

{
    private Rigidbody2D rb;
    private BoxCollider2D coll;
    private SpriteRenderer sprite;
    private Animator anim;

    [SerializeField] private LayerMask jumpableGround;


    private float dirX=0f;
    [SerializeField] private float moveSpeed=7f;
    [SerializeField] private float jumpForce = 14f;
    [SerializeField] private float ketchupPushForce = 5f;
    [SerializeField] private float moveSpeedOnMustard = 14f;




    private enum MovementState { idle, running, jumping, falling }

    private bool isInKetchup = false;
    private bool isOnMustard = false;
    private bool isInMustardState = false;
    private bool isOnGround = true;





    //int wholeNumber = 16;
    //float decimalNumber = 4.54f;
    //string text = "blabla";
    //bool boolean = false;



    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        coll = GetComponent<BoxCollider2D>();
        sprite = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    private void Update()
    {

        //float dirX = Input.GetAxis("Horizontal");
        dirX = Input.GetAxisRaw("Horizontal");

        if (isInMustardState)
        {
            rb.velocity = new Vector2(dirX * moveSpeedOnMustard, rb.velocity.y);
        }
        else 
        {
            rb.velocity = new Vector2(dirX * moveSpeed, rb.velocity.y);
        }


        // if (Input.GetKeyDown("space"))
        if (Input.GetButtonDown("Jump") && (IsGrounded() || isInKetchup))
        {
            rb.velocity = new Vector3(rb.velocity.x, jumpForce);
        }



        UpdateAnimationState();



    }


    private void UpdateAnimationState()
    {
        MovementState state;


        if (dirX > 0f)
        {
            state=MovementState.running;
            sprite.flipX = false;
        }
        else if (dirX < 0f)
        {
            state = MovementState.running;
            sprite.flipX = true;
        }
        else
        {
            state = MovementState.idle;
        }


        if (rb.velocity.y > .1f)
        {
            state = MovementState.jumping;
        }
        else if (rb.velocity.y < -.1f)
        {
            state = MovementState.falling;
        }


        anim.SetInteger("state", (int)state);
    }

    private bool IsGrounded()
    {
        return Physics2D.BoxCast(coll.bounds.center, coll.bounds.size, 0f, Vector2.down, .1f, jumpableGround);  
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ketchup"))
        {
            isInKetchup = true;
            rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y + ketchupPushForce);
        }

        if (collision.gameObject.CompareTag("Mustard"))
        {
            isOnMustard = true;
            isInMustardState = true;
        }
        
    }


    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ketchup"))
        {
            isInKetchup = false;
        }

        if (collision.gameObject.CompareTag("Mustard"))
        {
            isOnMustard = false;

            if (isOnGround)
            {
                isInMustardState = false;
            }

        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
            if (isOnMustard)
            {
                isInMustardState = true;
            }
            else 
            {
                isInMustardState = false;
            }

        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = false;
        }

    }







}
