using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool IsGameover = false;
    public int LoseSceneNumber;
    // Start is called before the first frame update
    private void Awake()
    {
        Time.timeScale = 1f;
       
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CheckGameOver();
        EndGame();
    }

    void CheckGameOver()
    {
        if (playerMovementSc.instance.Playerhealth == playerMovementSc.instance.Minhealth)
        {
            IsGameover = true;
        }
    }

    void EndGame()
    {
        if (IsGameover == true)
        {
            SceneManager.LoadScene(LoseSceneNumber);
        }
    }
}
