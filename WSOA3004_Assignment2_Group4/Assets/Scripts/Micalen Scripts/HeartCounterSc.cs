﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartCounterSc : MonoBehaviour
{
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
          UIManagerSc.instance.Hearts += 1;
        }
        
    }
}
