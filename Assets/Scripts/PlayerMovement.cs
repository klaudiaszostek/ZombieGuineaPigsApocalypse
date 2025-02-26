using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

class PlayerMovement : MonoBehaviour
{
    [SerializeField] private LayerMask blockingWalls;
    [SerializeField] private GuineaPig playerGuineaPig;
    private Rigidbody2D rb;
    private float dirX = 0f;
    private float dirY = 0f;
    private Animator anim;
    private SpriteRenderer sprite;
    private float moveSpeedDirX = 3f;
    private float moveSpeedDirY = 2f; //"[SerializeField]" is better than "public"
    private enum MovementState
    {
        idle, running
    }
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }
    private void Update()
    {

        dirX = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(dirX * moveSpeedDirX, rb.velocity.y);
        dirY = Input.GetAxisRaw("Vertical");
        rb.velocity = new Vector2(rb.velocity.x, dirY * moveSpeedDirY);
        if(Input.GetKeyDown(KeyCode.F))
        {
            playerGuineaPig.Attack(playerGuineaPig.Damage);
        }

        UpdateAnimationState();
    }
    private void UpdateAnimationState()
    {
        if (dirX != 0 || dirY != 0)
        {
            anim.SetTrigger("run");
        }
        else
        {
            anim.SetTrigger("idle");
        }
        if (dirX > 0f)
        {
            sprite.flipX = false;
        }
        else if (dirX < 0f)
        {
            sprite.flipX = true;
        }
    }
}
