using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float MoveSpeed;
    public Rigidbody2D rb;
    public Animator animator;

    private Vector2 MoveDirection;
    private bool facingRight;
    private bool dead;
    private float px;
    private float py;

    private void Start()
    {
        dead = false;
        px = transform.position.x;
        py = transform.position.y;
        
    }

    void Update()
    {
        if (dead)
        {
            dead = false;
            transform.position = new Vector2(px, py);
        }
        ProcessInputs();

        animator.SetFloat("Speed", Mathf.Abs((MoveDirection.x) * MoveSpeed) + Mathf.Abs((MoveDirection.y) * MoveSpeed));
    }

    void FixedUpdate()
    {
        Move();
    }

    void ProcessInputs()
    {
        float MoveX = Input.GetAxisRaw("Horizontal");
        float MoveY = Input.GetAxisRaw("Vertical");

        MoveDirection = new Vector2(MoveX, MoveY).normalized;

        if(facingRight == true && MoveX > 0)
        {
            flip();
        } else if(facingRight == false && MoveX < 0)
        {
            flip();
        }
    }

    void Move()
    {
        rb.velocity = new Vector2(MoveDirection.x * MoveSpeed, MoveDirection.y * MoveSpeed);
    }

    void flip()
    {
        facingRight = !facingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("arrow"))
        {
            die();
        }
        if(other.CompareTag("bomb"))
        {
            die();
        }
    }
    void die()
    {
        dead = true;
    }
}
