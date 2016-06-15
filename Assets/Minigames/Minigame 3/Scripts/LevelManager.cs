using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	/*
	 * Since this minigame was first written in using a two year old version of the Unity C# API, some of the physics 
	 * implementation does not function as we had hoped. Due to time restraints we opted to make quick fixes regarding 
	 * some deprecated functions, switching them out for what Unity had suggested. The result of this is that the ball 
	 * bounces in an awkward way.
	 */ 

	public GameObject endGameCanvas;

	public void LoadLevel(string name){
		Debug.Log ("New Level load: " + name);
		Brick.breakableCount = 0;
		Application.LoadLevel (name);
	}

	public void QuitRequest(){
		Debug.Log ("Quit requested");
		Application.Quit ();
	}
	
	public void LoadNextLevel() {
		Brick.breakableCount = 0;
		Application.LoadLevel(Application.loadedLevel + 1);
	}
	
	public void BrickDestoyed() {
		if (Brick.breakableCount <= 0) {
			LoadNextLevel();
		}
	}
	
	public void endGameScreen(){
		endGameCanvas.SetActive (true);
	}
}
