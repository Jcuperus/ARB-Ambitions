using UnityEngine;
using System.Collections;
using System;

public class PlayerMovement : MonoBehaviour {
    public float Speed = 0f;
    public float MaxJumpTime = 2f;
    public float JumpForce;
    private Rigidbody2D rb;
    private SpriteRenderer sr;
    private Animator anim;
    public Animation walkAnimation;
    public Animation jumpAnimation;
    private float move = 0f;
    private float JumpTime = 0f;
    private bool CanJump;
        
    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
        JumpTime = MaxJumpTime;
    }
	
	// Update is called once per frame
    void Update()
    {
        if (!CanJump)
            JumpTime -= Time.deltaTime;
        if (JumpTime <= 0)
        {
            CanJump = true;
            JumpTime = MaxJumpTime;
        }


    }

    void FixedUpdate()
    {
        move = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(move * Speed, rb.velocity.y);
        if (Input.GetKey(KeyCode.W) && CanJump && GetComponent<GroundHitCheck>().isGrounded)
        {
            rb.AddForce(new Vector2(rb.velocity.x, JumpForce));
            CanJump = false;
            JumpTime = MaxJumpTime;
        }

        animationToggle();
        flipSprite();
    }
    
    void flipSprite()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            sr.flipX = true;
        }
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            sr.flipX = false;
        }
    }

    void animationToggle()
    {
        anim.enabled = rb.velocity.x != 0;

        //if (rb.velocity.y != 0)
        //{
        //    jumpAnimation.Play();
        //}
    }
}
