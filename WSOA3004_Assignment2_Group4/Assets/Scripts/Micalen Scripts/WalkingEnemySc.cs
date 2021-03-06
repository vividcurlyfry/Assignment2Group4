﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkingEnemySc : MonoBehaviour
{
    public static WalkingEnemySc instance;
    public Rigidbody2D ThisEnemyRB;
    public float WalkSpeed;

    private Animator anim;
    // Start is called before the first frame update
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
      ThisEnemyRB = GetComponent<Rigidbody2D>();

        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        ThisEnemyRB.velocity = new Vector2(WalkSpeed, ThisEnemyRB.velocity.y);

        //for anim
        anim.SetFloat("Speed", Mathf.Abs(WalkSpeed));

        //flip sprite
        Vector2 turn = new Vector2(ThisEnemyRB.velocity.x, 0);
        transform.rotation = Quaternion.FromToRotation(Vector3.left, turn);
    }

    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "redirect")
        {
            this.WalkSpeed = WalkSpeed * -1f;
        } 
    }
}
