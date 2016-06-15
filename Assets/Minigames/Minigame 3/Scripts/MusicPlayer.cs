using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour {

	/*
	 * Since this minigame was first written in using a two year old version of the Unity C# API, some of the physics 
	 * implementation does not function as we had hoped. Due to time restraints we opted to make quick fixes regarding 
	 * some deprecated functions, switching them out for what Unity had suggested. The result of this is that the ball 
	 * bounces in an awkward way.
	 */ 

	static MusicPlayer instance = null;
	
	// Use this for initialization
	void Start () {
		if (instance != null) {
			Destroy (gameObject);
			print ("Duplicate music player self-destructing!");
		} else {
			instance = this;
			GameObject.DontDestroyOnLoad(gameObject);
		}
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
