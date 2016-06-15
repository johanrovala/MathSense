using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class MainLevelScript : MonoBehaviour {

	private int answer = 10;
	private int userGuess;
	public InputField userGuessField;
	Image[] inputFieldSprites;

	public GameObject[] clue1;
	public GameObject[] clue2;


	// for some odd reason setting dontPlayOnAwake to false in either Awake or Start did not stop the button sound from
	// playing as the scene was initialized. The result of which is some ugly code where we change AudioSource.enabled several times.


	

	void Start(){

		//MusicScript.Play ();

		inputFieldSprites = Resources.LoadAll<Image> ("UI Sprites/answerField");
		Debug.Log (inputFieldSprites.Length);

		if (ClueMaster.firstClueActive) {
			Debug.Log("Change clue 1");
			clue1[0].SetActive (false);
			clue1[1].SetActive (true);
		}
		if (ClueMaster.secondClueActive) {
			Debug.Log("Change clue 2");
			clue2[0].SetActive (false);
			clue2[1].SetActive (true);
		}
	}
		
	public void launchShop(){
		ButtonSound.playSound ();
		Application.LoadLevel ("StoreScene");
	}

	public void answerEquation() {
		ButtonSound.playSound ();
		try{
			userGuess = int.Parse(userGuessField.text);
		}catch (FormatException){
			Debug.Log("User tried to use invalid input, ie anything but a number");
		}catch (OverflowException){
			Debug.Log("User input was to big (larger than an int)");
		}
		if (isAnswerCorrect()) {
			displayAnswerCorrect ();
		} else {
			displayAnswerIncorrect();
		}
	}

	void displayAnswerCorrect() {
		Debug.Log ("Correct answer");
		userGuessField.image.GetComponent<Image>().color = new Color32(133, 255, 175, 255);
	}

	void displayAnswerIncorrect() {
		Debug.Log ("Incorrect answer");
		userGuessField.image.GetComponent<Image>().color = new Color32(255, 133, 147, 255);
	}

	bool isAnswerCorrect() {
		return userGuess.Equals (answer);
	}
}
