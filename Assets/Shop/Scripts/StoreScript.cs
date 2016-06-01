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
		Level level1 = new Level (19, "level2");
		levelList.Add (level1);
		Level level2 = new Level (19, "level1");
		levelList.Add (level2);
		Level level3 = new Level (19, "Level_01");
		levelList.Add (level3);

		//destroySprite (clue1);
	}

	private void Awake(){

		textTest = GameObject.Find ("AmountOfCoinText").GetComponent<Text> ();
		clueButton = GameObject.Find ("Canvas").GetComponentsInChildren<Button>();
		print (Coin.getCoinScore ());

		Debug.Log ("Awake running");
	}


	public void launchLevel(int i) {
		levelList [i].launchLevel ();
	}
	/*
	private void saveSprite(Clue c){
			markedObjects.Add(c);
			Debug.Log ("Save");
			print (markedObjects [0]);
			DontDestroyOnLoad (c.getSprite());
	}

	private void destroySprite(Clue c){
		foreach(Clue g in markedObjects){
			print (g);
			if (g.getId() != c.getId()){
				Debug.Log("Destroy");
				c.destroyThis();
			}else{
				Debug.Log("Id's are equal");
			}
		}
		Debug.Log ("First iteration");
	}*/

	public void buyClue(int i) {
		clueList [i].activate ();
		updateCoinText ();
		//saveSprite (clueList[i]);
		// not the best solution, just implemented in order to have a working product for the presentation.
		clueButton [i+3].interactable = false;
	}

	public void backToMainlevel() {
		Application.LoadLevel ("mainlevel_1");
	}

	private void updateCoinText() {
		textTest.text = Coin.getCoinScore().ToString();
	}
	
}
