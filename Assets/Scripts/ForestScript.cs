using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*Clase que maneja al personaje principal en niveles terrestres*/
public class ForestScript : MonoBehaviour
{

    public float jumpForce = 200f;
    private Rigidbody2D rb;
    public Animator anim;
    private float move;
    public GameObject feet;
    public LayerMask layerMask;
   // AudioSource muerteS;
    public float speed = 50f;
    AudioSource saltoS;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        //muerteS = GetComponent<AudioSource>();
       saltoS = GetComponent<AudioSource>();
    }

    void Update()
    {
        move = Input.GetAxis("Horizontal");

        //anim.SetFloat("Speed", Mathf.Abs(move)*speed);

        if (Input.GetMouseButtonDown(0))
        {
            
            rb.velocity = Vector2.zero;
            rb.AddForce(Vector2.up * jumpForce);
            saltoS.Play();
            
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameController.instance.score++;
        Debug.Log(GameController.instance.score);
        GameController.instance.gameOver = true;
       // muerteS.Play();
       
        


    }

    

}
