using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player obj;

    public int lives = 3;


    public bool isGrounded = false;
    public bool isMooving = false;
    public bool isImmune = false;
    


    public float speed = 5f;
    public float jumpForce = 3f;
    public float movHor;


    public float immuneTimeCnt = 0f;
    public float immuneTime = 0.5f;

    public LayerMask groundLayer;
    public float radius = 0.3f;
    public float groundRayDist = 0.5f;

    private Rigidbody2D rb;
    private Animator anim;
    private SpriteRenderer spr;

    void Awake ()
    {
      obj = this;

       
    }


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();   
        spr = GetComponent<SpriteRenderer>();
    }

  

    void Update()
    {
        movHor = Input.GetAxisRaw("Horizontal");
    }


    void FixedUpdate()
    {
        rb.velocity = new Vector2(movHor * speed, rb.velocity.y);
    }


    void OnDestroy ()
    {
      obj = null;

    }
}
