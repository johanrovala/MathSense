using UnityEngine;
using System.Collections;

public class StartLevel : MonoBehaviour {

	public AudioSource bSound;
	public AudioSource bgMusic;

	void Start() {
		ButtonSound buttonSound = new ButtonSound (bSound);
		BackgroundMusic backgroundMusic = new BackgroundMusic (bgMusic); 
		BackgroundMusic.PlaySound ();
	}
	
	
	public void LoadStage() {
		ButtonSound.playSound ();
		Application.LoadLevel ("MainLevel");
	}
}
