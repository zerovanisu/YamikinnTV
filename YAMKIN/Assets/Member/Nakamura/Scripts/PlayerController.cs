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

    [SerializeField]
    private float maxjump;

    private float speed;


    private float x_val;
    private float jumppower;

    public bool jumpFlg;
    private bool nowJumpFlg;


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
            jumppower = this.transform.position.y + maxjump;
            nowJumpFlg = true;
        }

        if (maxjump <= this.transform.position.y)
        {
            nowJumpFlg = false;
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            nowJumpFlg = false;
        }

        if(nowJumpFlg&& maxjump >= this.transform.position.y)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }

    }

}