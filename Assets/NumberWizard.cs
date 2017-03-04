using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class NumberWizard : MonoBehaviour
{
	
	public Text variableText;	
	public int maxGuessesAllowed; 
	
	int max;
	int min;
	int guess;
	

	void Start()
	{
		max = 1000;
		min = 1;
		
	}
		
	void Update ()
	{
//		Easy ();
//		Hard ();
//		Relentless ();
	}
	public void Easy()
	{
		maxGuessesAllowed = 5;		
		NextGuess();
	}
	
	public void Hard()
	{
		maxGuessesAllowed = 10;
		NextGuess();
	}
	
	public void Relentless()
	{
		maxGuessesAllowed = 25;
		NextGuess();
	}
	
	public void GuessHigher()
	{
		min = guess;
		NextGuess();
	}
	
	public void GuessLower()
	{
		max = guess;
		NextGuess ();
	}
	
	void NextGuess()
	{	
		guess = Random.Range(min,max+1);
				
		// Turns the variable 'guess' into a 'string' which in turn is set to be the 'text' shown on screen via variableText 
		variableText.text = guess.ToString(); 
		maxGuessesAllowed = maxGuessesAllowed - 1;
		if (maxGuessesAllowed <=0)
		{
			Application.LoadLevel("Win");
		}
	}
}