﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UserInterfaceManager : MonoBehaviour {

    public void tip()
    {
        SceneManager.LoadScene("002_tips");
    }
    public void level1()
    {
        SceneManager.LoadScene("002_tips");
    }
    public void SalirGame()
    {
        Application.Quit();
    }
}
