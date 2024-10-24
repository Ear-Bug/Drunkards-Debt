using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenuStartButtomScript : MonoBehaviour 
{
    [SerializeField] private string newGameLevel = "Table";

    public void NewGameButton()
    {
        SceneManager.LoadScene(newGameLevel, LoadSceneMode.Single);
    }    

}

