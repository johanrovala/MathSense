using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StoreScript : MonoBehaviour {

	Button[] clueButton;
	Texture2D transitionSprite;
	SpriteRenderer bg;
	Sprite test;

	// Use this for initialization
	void Start () {
		clueButton = GameObject.Find ("Canvas").GetComponentsInChildren<Button>();
		transitionSprite = Instantiate (Resources.Load ("Watermelon")) as Texture2D;
		Rect rec = new Rect (0, 0, transitionSprite.width, transitionSprite.height);
		test = Sprite.Create (transitionSprite, rec, new Vector2(0,0), 1);
		//bg.sprite = Sprite.Create (transitionSprite, rec, new Vector2(0, 0),1f);
		print (Resources.Load ("Watermelon"));
		print (transitionSprite);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void LoadStage() {
		print ("button works");
		Level level = new Level (19, "testLudde");
		level.launchLevel ();	
	}

	public void clueButtonTransition(int i) {
		Button button = clueButton [i];
		button.image.sprite = test;
		print (transitionSprite);
	}
}
