using UnityEngine;
using System.Collections;

public class BackgroundMusic : MonoBehaviour {

	private static AudioSource backgroundMusic;

	public BackgroundMusic (AudioSource inputSound){
		backgroundMusic = inputSound;
		Start ();
	}

	public static void PlaySound() {
		backgroundMusic.Play ();
	}

	public static void Pause () {
		backgroundMusic.Pause ();
	}

	public static void UnPause () {
		backgroundMusic.UnPause ();
	}

	// Use this for initialization
	void Start () {
		DontDestroyOnLoad (backgroundMusic);
	}
	

}
