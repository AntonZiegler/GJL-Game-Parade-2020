﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class MainMenuButtons : MonoBehaviour
{
    [SerializeField] string gameScene = "Game";
    // Start is called before the first frame update

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   public void StartGame()
    {
        SceneManager.LoadScene(gameScene);
    }

    public void QuitApplication()
    {
        Application.Quit();
    }
}
