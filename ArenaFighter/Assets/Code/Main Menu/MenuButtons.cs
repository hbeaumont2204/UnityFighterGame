using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading.Tasks;
using System.IO;
using System;
using TMPro;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class MenuButtons : MonoBehaviour
{
    // Main Menu buttons
    public void play_game()
    {
        SceneManager.LoadSceneAsync("Lobby");
    }

    public void loadGame()
    {
        
    }
    public void quit_game()
    {
        Application.Quit();
    }
    // Pause Menu buttons
    public void main_menu()
    {
        SceneManager.LoadSceneAsync("Main Menu");
    }

}