using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followEnemySc : MonoBehaviour
{
    public bool triggered;
    private Vector2 CurPos;
    private Rigidbody2D FollowEnemRB;
    private GameObject target;
    public float movespeed;
    public float MinMovespeed;
    public float Maxmovespeed;
    Vector2 direction;
    public float NotTrigRadius;
    public float TrigRadius;
    // Start is called before the first frame update
    void Start()
    {
        triggered = false;
        CurPos = new Vector2(transform.position.x, transform.position.y);
    }

    // Update is called once per frame
    void Update()
    {
        

        if (triggered == false)
        {
            transform.position = CurPos;
            transform.GetComponent<CircleCollider2D>().radius = NotTrigRadius;
            movespeed = MinMovespeed;
        }

        if (triggered == true)
        {
            movespeed = Maxmovespeed;
            FollowEnemRB = GetComponent<Rigidbody2D>();
            target = GameObject.FindGameObjectWithTag("Player");
            direction = (target.transform.position - transform.position).normalized * movespeed;
            FollowEnemRB.velocity = new Vector2(direction.x, direction.y);
            transform.GetComponent<CircleCollider2D>().radius = TrigRadius;
            
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            triggered = true;
           
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            triggered = false;
            CurPos = new Vector2(transform.position.x, transform.position.y);
        }
    }
}
