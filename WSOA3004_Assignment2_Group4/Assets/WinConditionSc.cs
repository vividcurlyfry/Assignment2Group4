using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinConditionSc : MonoBehaviour
{
    public static WinConditionSc instance;
    public int ObjCollected;
    public int ObjNeededToCollect;
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
        CheckWin();
    }
    public void CheckWin()
    {
        if (ObjCollected == ObjNeededToCollect)
        {
            //this will create the key
            Door_EndLevelSc.instance.hasKey = true;
        }
    }
}
