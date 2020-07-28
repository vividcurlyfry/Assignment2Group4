using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_EndLevelSc : MonoBehaviour
{
    public static Door_EndLevelSc instance;
    public bool hasKey = false;
    public GameObject NextLevel;
    // Start is called before the first frame update
    private void Awake()
    {
        instance = this;

        NextLevel.SetActive(false);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EndLevel()
    {
        if (hasKey == true)
        {
            NextLevel.SetActive(true);
            Time.timeScale = 0f;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            EndLevel();
        }
    }
}
