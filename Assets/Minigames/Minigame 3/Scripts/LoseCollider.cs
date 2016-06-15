using UnityEngine;
using System.Collections;

public class LoseCollider : MonoBehaviour {

	/*
	 * Since this minigame was first written in using a two year old version of the Unity C# API, some of the physics 
	 * implementation does not function as we had hoped. Due to time restraints we opted to make quick fixes regarding 
	 * some deprecated functions, switching them out for what Unity had suggested. The result of this is that the ball 
	 * bounces in an awkward way.
	 */ 

	private LevelManager levelManager;
	
	void OnTriggerEnter2D (Collider2D trigger) {
		levelManager = GameObject.FindObjectOfType<LevelManager>();
		BackgroundMusic.Pause ();
		levelManager.endGameScreen();
	}
	
	void OnCollisionEnter2D (Collision2D collision) {
		print ("Collision");	
	}
	
}
