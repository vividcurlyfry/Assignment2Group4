using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerMovementSc : MonoBehaviour
{
    public static playerMovementSc instance;
    public Rigidbody2D rb;
    public float JumpForce;
    public float speed;
    public bool isGrounded;
    public Slider PlayerHealthBar;
    public int Playerhealth = 100;
    public int Maxhealth = 100;
    public int Minhealth = 0;
    // Start is called before the first frame update
    private void Awake()
    {
        instance = this; 
    }
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();  
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        playerhealthcheck();
        PlayerHealthBar.value = Playerhealth;
        
    }
    public void Movement()
    {
        //Horizontal Movement
        float x = Input.GetAxisRaw("Horizontal");
        float move= x * speed;
        rb.velocity = new Vector2(move, rb.velocity.y);

        //Jumping
        if ((Input.GetKeyDown(KeyCode.Space)) && (isGrounded == true))
        {
            rb.velocity = new Vector2(rb.velocity.x, JumpForce);
            isGrounded = false;
        }
    }
    
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "platform")
        {
            isGrounded = true;
        }
        
    }
    public void playerhealthcheck()
    {
        if (Playerhealth > Maxhealth)
        {
            Playerhealth = Maxhealth;
        }
        if (Playerhealth < Minhealth)
        {
            Playerhealth = Minhealth;
        }
    }
}
