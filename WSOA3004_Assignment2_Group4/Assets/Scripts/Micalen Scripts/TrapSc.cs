using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapSc : MonoBehaviour
{
    public int TrapDamage;

    public GameObject sound;
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
            playerMovementSc.instance.Playerhealth -= TrapDamage;

            Instantiate(sound, transform.position, Quaternion.identity);
        }
    }
}
