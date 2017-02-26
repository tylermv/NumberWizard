using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LevelManager : MonoBehaviour {

	public void LoadLevel(string name) {
		Debug.Log ("Level load requested for " +name);
		Application.LoadLevel (name);
	}
	public void QuitRequest(string name) {
		Debug.Log ("Quit game requested for ");
		Application.Quit();
	}
}