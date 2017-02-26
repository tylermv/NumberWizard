using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {
// Use this for initialization

	int max;
	int min;
	int guess;
	int maxGuessesAllowed = 11;

	public Text text;

	void Start () {
		StartGame ();
	}

	void StartGame () {
		
		max = 1000;
		min = 1;
		NextGuess ();
	}

	void RandomGuess () {
		guess = Random.Range (1, 1000);
	}
		
	void NextGuess () {
		guess = Random.Range(max,min+1);
		text.text = guess.ToString ();
		maxGuessesAllowed = maxGuessesAllowed - 1;
		if (maxGuessesAllowed <= 0) {
			Application.LoadLevel ("Win");
		}
	}
	public void GuessHigher () {
		min = guess;
		NextGuess();
	}
	public void GuessLower () {
		max = guess;
		NextGuess();
		}
	}