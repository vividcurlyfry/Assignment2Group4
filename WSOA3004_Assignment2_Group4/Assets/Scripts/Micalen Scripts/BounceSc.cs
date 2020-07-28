using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceSc : MonoBehaviour
{
    public float BounceForce;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            playerMovementSc.instance.rb.velocity = new Vector2(playerMovementSc.instance.rb.velocity.x, BounceForce);
            playerMovementSc.instance.isGrounded = false;
        }
    }
}
