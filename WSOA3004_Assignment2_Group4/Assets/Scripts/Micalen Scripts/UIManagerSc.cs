using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManagerSc : MonoBehaviour
{
    public static UIManagerSc instance;
    public Text ToeTxt, BrainTxt, HeartTxt;
    public int Toes = 0, Brains = 0, Hearts = 0;
    public int TotalToes, TotalBrains, TotalHearts;
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
        ToeTxt.text = Toes.ToString() + "/" + TotalToes.ToString();
        BrainTxt.text = Brains.ToString() + "/" + TotalBrains.ToString();
        HeartTxt.text = Hearts.ToString() + "/" + TotalHearts.ToString();
    }
}
