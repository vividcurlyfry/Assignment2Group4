using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sickCoverManagerSc : MonoBehaviour
{
    public static sickCoverManagerSc instance;
    public Animator SickCoverAnim;
    public bool KeypickScWorked;
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
        if (KeypickScWorked == true)
        {
            SickCoverAnim.SetBool("GotSick", true);
        }
    }
}
