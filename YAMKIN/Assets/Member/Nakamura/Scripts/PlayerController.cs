using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(BoxCollider2D))]
public class PlayerController : MonoBehaviour
{
    [SerializeField,Header("プレイヤーの速度")]
    private float inputSpeed;

    [SerializeField]
    private Rigidbody2D rb;

    [SerializeField]
    private float jumpForce = 10f;

    private float speed;

    private int jumpCount = 0;

    private float x_val;
    private bool jumpFlg;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {

        if (x_val == 0)
        {
            speed = 0;
        }

        else if (x_val > 0)
        {
            speed = inputSpeed;

        }

        else if (x_val < 0)
        {
            speed = inputSpeed * -1;

        }

        rb.velocity = new Vector2(speed, rb.velocity.y);
    }
    void Update()
    {
        x_val = Input.GetAxis("Horizontal");

        if (Input.GetKeyDown(KeyCode.Space) && jumpFlg)
        {
            jump();
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Floor"))
        {
            jumpFlg= true;
        }
    }
    void jump()
    {
        rb.AddForce(Vector2.up * jumpForce);
        jumpFlg = false;
    }

}