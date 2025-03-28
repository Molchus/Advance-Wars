using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_Start_Pause : MonoBehaviour
{
    public static bool gamePaused = false;
	public GameObject menu;
	public AudioSource Pause_Sound;

	void Start()
	{
		LockMouse();		
	}
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			if(gamePaused == false)
			{
				Pause_Sound.Play();
				Pause();
				Debug.Log("Pause");
			}
		}
	}
	
	public bool getGameIsPaused()
    {
		return gamePaused;
    }

    public void Pause ()
	{
		Time.timeScale = 0f;
		gamePaused = true;
		menu.SetActive(true);
		Cursor.lockState = CursorLockMode.None;
		Cursor.visible = true;

	}

    public void Play()
	{
		Time.timeScale = 1f;
		gamePaused = false;
		LockMouse();
	}

	public void Menu()
	{
		Time.timeScale = 1f;
		gamePaused = false;
	}
	void LockMouse()
	{
		Cursor.lockState = CursorLockMode.None;
		Cursor.visible = false;
	}
}

