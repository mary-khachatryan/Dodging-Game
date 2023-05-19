using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
	public void Play()
	{
		SceneManager.LoadScene("Game");
	}

	public void Quit()
	{
		Application.Quit();
	}
	public void Menu()
	{
		SceneManager.LoadScene("Main Menu");
	}
}
