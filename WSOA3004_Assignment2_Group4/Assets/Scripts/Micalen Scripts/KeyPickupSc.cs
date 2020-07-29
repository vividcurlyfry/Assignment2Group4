using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPickupSc : MonoBehaviour
{
    public static KeyPickupSc instance;
    // Start is called before the first frame update
    private void Awake()
    {
        instance = this;
    }
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
            sickCoverManagerSc.instance.KeypickScWorked = true;
            WinConditionSc.instance.ObjCollected += 1;
            DestoryPickup();
        }
    }
    void DestoryPickup()
    {
      Destroy(gameObject);
    }
}
