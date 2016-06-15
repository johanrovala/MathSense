using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;


public class ButtonSound : MonoBehaviour{


	private static AudioSource buttonSound;

	public ButtonSound(AudioSource inputSound) {
		buttonSound = inputSound;
		//buttonSound.enabled = false;
		Start ();
	}

	public static void playSound(){
		//buttonSound.enabled = true;
		buttonSound.Play ();
	}

	void Start(){
		DontDestroyOnLoad (buttonSound);
	}

}
