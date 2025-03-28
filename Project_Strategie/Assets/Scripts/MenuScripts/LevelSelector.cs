using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.Events;


public class levelSelector : MonoBehaviour
{
    public KeyCode reloadKey = KeyCode.H;

    public void Levlel1()
    {
        SceneManager.LoadScene("1.Level1");
    }
    public void Level2()
    {
        SceneManager.LoadScene("2.Level2");
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void Menu()
    {
        SceneManager.LoadScene("0.Menu");
    }

    private void Update()
    {
        
        if (Input.GetKeyDown(reloadKey))
        {
            SceneManager.LoadScene("0.Menu");
        }
    }

}
