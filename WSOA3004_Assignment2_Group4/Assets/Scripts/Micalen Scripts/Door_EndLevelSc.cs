using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door_EndLevelSc : MonoBehaviour
{
    public static Door_EndLevelSc instance;
    public bool hasKey = false;
    public int WinSceneNumber;
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

    public void EndLevel()
    {
        if (hasKey == true)
        {
            SceneManager.LoadScene(WinSceneNumber);
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
