using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Link : MonoBehaviour 
{
	public Canvas LinkCanvas;

	public void LoadLink()
	{
		Application.OpenURL ("http://globalgamejam.org/2016/games/pierrz");
	}

	public void BackToMenu()
	{
		Application.LoadLevel (0);
	}
}