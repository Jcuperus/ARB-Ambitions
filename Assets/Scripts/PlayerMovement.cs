using UnityEngine;
using System.Collections;
using System;

public class PlayerMovement : MonoBehaviour {
    public float Speed = 0f;
    public float MaxJumpTime = 2f;
    public float JumpForce;
    private Rigidbody2D rb;
    private float move = 0f;
    private float JumpTime = 0f;
    private bool CanJump;
        
    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
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
    }
}
