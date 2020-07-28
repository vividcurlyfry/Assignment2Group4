using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickupSc : MonoBehaviour
{
    public int AddHealth;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (playerMovementSc.instance.Playerhealth < playerMovementSc.instance.Maxhealth)
            {
             playerMovementSc.instance.Playerhealth += AddHealth;
             Destroy(gameObject);
            }
            
        }
    }
}
