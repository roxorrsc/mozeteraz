using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    public float speed;
    private Vector3 moveDirection;

    private bool jump;
    private bool isGrounded;
    public float jumpPower = 1f;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        jump = Input.GetButton("Jump");

        moveDirection = new Vector3(moveHorizontal, 0.0f, moveVertical);
    }

    private void FixedUpdate()
    {
        Move();
        Jump();
    }
    void Move()
    {
        rb.AddForce(moveDirection * speed);
    }

    void Jump()
    {
        isGrounded = Physics.Raycast(transform.position, Vector3.down, 1f);

        if (jump && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
        }
    }
}