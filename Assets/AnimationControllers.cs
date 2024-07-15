using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationControllers : MonoBehaviour
{
    // Start is called before the first frame update

    private Animator animator;
    private Rigidbody rb;
    public float walkSpeed = 2f;

    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveSpeed = 0f;

        if (Input.GetKey(KeyCode.W))
        {
            moveSpeed = walkSpeed;
            animator.SetBool("isWalking", true);
            animator.SetBool("isRunning", false);
            animator.SetBool("isJumping", false);
        }
         else if (Input.GetKey(KeyCode.LeftShift))
        {
            animator.SetBool("isWalking", false);
            animator.SetBool("isRunning", true);
            animator.SetBool("isJumping", false);
        }
         else if (Input.GetKey(KeyCode.Space))
        {
            animator.SetBool("isWalking", false);
            animator.SetBool("isRunning", false);
            animator.SetBool("isJumping", true);
        }
        else
        {
            animator.SetBool("isWalking", false);
            animator.SetBool("isRunning", false);
            animator.SetBool("isJumping", false);

        }
        Vector3 move = transform.forward * moveSpeed * Time.deltaTime;
        rb.MovePosition(rb.position + move);
    }
}
