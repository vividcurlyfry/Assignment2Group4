using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyChangeSc : MonoBehaviour
{
    public GameObject UICollect, KeyHas;
    // Start is called before the first frame update
    void Start()
    {
        KeyHas.SetActive(false); 
    }

    // Update is called once per frame
    void Update()
    {
        if (Door_EndLevelSc.instance.hasKey == true)
        {
            UICollect.SetActive(false);
            KeyHas.SetActive(true);
        }  
    }
}
