using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class MainLevelScript : MonoBehaviour {

	private int answer = 10;
	private int userGuess;
	public InputField userGuessField;
	Image[] inputFieldSprites;


	void Start(){
		inputFieldSprites = Resources.LoadAll<Image> ("UI Sprites/answerField");
		Debug.Log (inputFieldSprites.Length);
	}
		
	public void launchShop(){
		Application.LoadLevel ("StoreScene");
	}

	public void answerEquation() {
		try{
			userGuess = int.Parse(userGuessField.text);
		}catch (FormatException e){
			Debug.Log("User tried to use invalid input, ie anything but a number");
		}catch (OverflowException e){
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
