using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player2dPlatform : MonoBehaviour
{
    private GameObject final;
    private Rigidbody2D rb2d;
    public float speed, jump;
    public bool detect, jumping, finalty;
    //[HideInInspector]
    public bool finished;
    private Life living, seeingFinal;
    public Detector deter;
    private int direction;
    public SpriteRenderer look;
    public Sprite idleSprite, runSprite;
    public Animator anim;
    public AudioSource sound;
    private Timer timeUI;

    void Awake()
    {
        timeUI = GameObject.FindGameObjectWithTag("Timer").GetComponent<Timer>();
    }
    // Start is called before the first frame update
    void Start()
    {
        //final = GameObject.FindGameObjectWithTag("Final");
        if (final != null)
        {
            finalty = true;
            seeingFinal = final.GetComponent<Life>();
        }
        else
        {
            finalty = false;
        }
        living = GetComponent<Life>();
        rb2d = GetComponent<Rigidbody2D>();
        direction = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (!timeUI.battle)
        {
            Move();
        }
        else
        {
            Vector3 vel = rb2d.velocity;
            vel.x = 0;
            rb2d.velocity = vel;
            look.sprite = idleSprite;
        }

    }

    void Move() {

        float h = Input.GetAxisRaw("Horizontal");
        if (h > 0)
        {
            direction = 1;
            //anim.SetBool("Mover", true);
            look.sprite = runSprite;
        }
        else if (h < 0)
        {
            direction = -1;
            //anim.SetBool("Mover", true);
            look.sprite = runSprite;
        }
        else
        {
            //anim.SetBool("Mover", false);
            look.sprite = idleSprite;
        }
        if (direction == 1)
        {
            //look.flipX = false;
            transform.localScale = new Vector3(1, 1, 1);
        }
        else
        {
            //look.flipX = true;
            transform.localScale = new Vector3(-1, 1, 1);
        }
        Vector3 vel = rb2d.velocity;
        vel.x = speed * h;
        rb2d.velocity = vel;

        if (IsGrounded() == false)
        {
            detect = true;
        }
        if (detect == true && vel.y < 0)
        {
            //vel.y = vel.y * -0.2f;
            //rb2d.velocity = vel;
            //anim.SetInteger("SaltoNúmero", 1);
            detect = false;
        }
        if (jumping && IsGrounded())
        {
            //anim.SetInteger("SaltoNúmero", 2);
        }


    }
    void FixedUpdate (){
        if (IsGrounded() && Input.GetAxis("Jump")>0.3)
        {
            jumping = true;
            rb2d.AddForce(transform.up * jump * 200);
            //anim.SetInteger("SaltoNúmero", 0);
        }

    }

    private bool IsGrounded()
    {
        return GroundCheck.isGrounded;
    }
}
