using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class StoreScript : MonoBehaviour {

	Button[] clueButton;
	Texture2D spriteTexture;
	Sprite clueSprite;
	List<Clue> clueList;
	List<Level> levelList;

	void Start () {


		clueButton = GameObject.Find ("Canvas").GetComponentsInChildren<Button>();
		print (Coin.getCoinScore ());

		clueList = new List<Clue> ();
		Clue clue1 = new Clue (10, "Watermelon", "Lemon", clueButton [1]);
		clueList.Add (clue1);
		Clue clue2 = new Clue (10, "Watermelon", "Lemon", clueButton [2]);
		clueList.Add (clue2);
		Clue clue3 = new Clue (10, "Watermelon", "Lemon", clueButton [3]);
		clueList.Add (clue3);

		levelList = new List<Level> ();	
		Level level1 = new Level (19, "minigame_1");
		levelList.Add (level1);

	}

	void Update () {


	}

	public void launchLevel(int i) {
		levelList [i].launchLevel ();
	}

	public void buyClue(int i) {
		clueList [i].activate ();
	}
	
}
