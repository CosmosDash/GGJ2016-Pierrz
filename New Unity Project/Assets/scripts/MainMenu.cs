using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MainMenu : MonoBehaviour 
{
	public Canvas MainCanvas;

	public void LoadGame()
	{
		Application.LoadLevel (1);
	}

	public void LoadCredits()
	{
		Application.LoadLevel (2);
	}

	public void ExitGame()
	{
		Application.Quit();
	}
}
