using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForestM2 : MonoBehaviour
{

    public float jumpForce = 200f;
    private Rigidbody2D rb;
    private float move;
    AudioSource muerteS;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

        move = Input.GetAxis("Horizontal");

        //anim.SetFloat("Speed", Mathf.Abs(move)*speed);

        if (Input.GetMouseButtonDown(0))
        {

            rb.velocity = Vector2.zero;
            rb.AddForce(Vector2.up * jumpForce);
            //saltoS.Play();

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameController.instance.score++;
        Debug.Log(GameController.instance.score);
        GameController.instance.gameOver = true;
        muerteS.Play();

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameController.instance.gameOver = true;

    }


}
