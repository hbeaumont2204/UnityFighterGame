using System;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;
using UnityEngine.UI;

public class DeathScreen : MonoBehaviour
{

    public Text xpLabel;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setXPLabel(String label)
    {
        xpLabel.text = label;
    }

    public void return_to_lobby()
    {
        
    }

    public void exit_game()
    {
        Application.Quit();
    }

}
