using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour
{
	public void LoadLevel(string name)
	{
		Debug.Log ("Requsting level: " +name);
		Application.LoadLevel(name);
	}

	public void QuitRequest()
	{
		Debug.Log ("Requesting to quit level");
		Application.Quit();
	}



}