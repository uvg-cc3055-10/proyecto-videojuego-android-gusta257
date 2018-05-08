using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForestScript : MonoBehaviour
{

    public float jumpForce = 100f;
    private Rigidbody2D rb;
    public Animator anim;
    private float move;
    AudioSource muerteS;
   // AudioSource saltoS;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        muerteS = GetComponent<AudioSource>();
       // saltoS = GetComponent<AudioSource>();
    }

    void Update()
    {
        move = Input.GetAxis("Horizontal");

        anim.SetFloat("Speed", Mathf.Abs(move));

        if (Input.GetButtonDown("Jump"))
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

    

}
