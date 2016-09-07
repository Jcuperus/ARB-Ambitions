using UnityEngine;
using System.Collections;

public class GroundHitCheck : MonoBehaviour {

    public bool isGrounded = false;
    public Transform GroundCheck;
    public LayerMask ground_layers;

    void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(GroundCheck.position, 1, ground_layers);
    }
}
