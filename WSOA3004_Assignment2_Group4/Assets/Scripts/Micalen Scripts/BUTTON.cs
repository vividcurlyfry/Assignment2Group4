﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BUTTON : MonoBehaviour
{
    public void LoadbyIndex(int SceneIndex)
    {
        SceneManager.LoadScene(SceneIndex);
    }
}
