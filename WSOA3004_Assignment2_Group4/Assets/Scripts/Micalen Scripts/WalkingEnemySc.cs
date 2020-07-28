using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkingEnemySc : MonoBehaviour
{
    public static WalkingEnemySc instance;
    public Rigidbody2D ThisEnemyRB;
    public float WalkSpeed;
    // Start is called before the first frame update
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
      ThisEnemyRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        ThisEnemyRB.velocity = new Vector2(WalkSpeed, ThisEnemyRB.velocity.y);
    }
}
