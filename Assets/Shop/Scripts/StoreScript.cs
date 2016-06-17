using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class StoreScript : MonoBehaviour {

	/*
	 * This script details all actions made in the Store scene. 
	 * There are attempts at making the script automated via the Clue and Level classes. However for example saving 
	 * a sprites state has not been completed, many different solutions have been tested but not successful. Part of this 
	 * is probably because of the added complexity of not simply having an entire sprite be the image of the buttons. 
	 * 
	 * Also disabling the buttons is not done in the prettiest way, this is just finished in order to have something that 
	 * works for the presentation. 
	 */

	Button[] clueButton;
	Texture2D spriteTexture;
	Sprite clueSprite;
	List<Clue> clueList;
	List<Level> levelList;
	private Text textTest;
	private Sprite[] testSprites;
	static List<Clue> markedObjects = new List<Clue>();	


	
	void Awake(){
		
		textTest = GameObject.Find ("CoinCountText").GetComponent<Text> ();
		clueButton = GameObject.Find ("Canvas").GetComponentsInChildren<Button>();
		Debug.Log ("length of buttonlist" + clueButton.Length);

		Debug.Log ("Awake running");
	}

	void Start () {

		Debug.Log ("Start running");

		updateCoinText ();

		clueList = new List<Clue> ();
		testSprites = Resources.LoadAll<Sprite> ("UI Sprites/numbers");
	 	SpriteRenderer sprite1 = GameObject.FindGameObjectWithTag ("clue1").GetComponent<SpriteRenderer>();
		Clue clue1 = new Clue (10, sprite1, testSprites[4], clueButton [3]);
		clueList.Add (clue1);
		SpriteRenderer sprite2 = GameObject.FindGameObjectWithTag ("clue2").GetComponent<SpriteRenderer>();
		Clue clue2 = new Clue (10, sprite2, testSprites[4], clueButton [4]);
		clueList.Add (clue2);
		
		levelList = new List<Level> ();	
		Level level1 = new Level (19, "MiniGame_1");
		levelList.Add (level1);
		Level level2 = new Level (19, "MiniGame_2");
		levelList.Add (level2);
		Level level3 = new Level (19, "MiniGame_3");
		levelList.Add (level3);

		// Check if our clues have previously been activated. 

		if (ClueMaster.firstClueActive) {
			clue1.keepActivated();
		}
		if (ClueMaster.secondClueActive) {
			clue2.keepActivated();
		}
	}

	public void launchLevel(int i) {
		ButtonSound.playSound ();
		levelList [i].launchLevel ();
	}

	public void buyClue(int i) {
		Debug.Log ("clue: " + i);
		ButtonSound.playSound ();
		clueList [i].activate (i);
		updateCoinText ();
	}

	public void backToMainlevel() {
		ButtonSound.playSound ();
		Application.LoadLevel ("MainLevel");
	}

	private void updateCoinText() {
		textTest.text = Coin.getCoinScore().ToString();
	}
	
}
