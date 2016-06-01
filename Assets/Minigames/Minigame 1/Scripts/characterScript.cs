using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class characterScript : MonoBehaviour{

	Rigidbody rb;
	public float jumpHeight;
	private bool triedJump = false;
	private bool onGround = true;
	private int jumpCount = 0;
	GameObject UIText;
	Vector3 v;
	public Text text;
	public int coinScore;
	public GameObject endGameCanvas;
		
	

	void Start () {
		rb = GetComponent<Rigidbody> ();
		coinScore = 0;
	}

	/*
	 * Update will be called every frame, looking for an input from the user.
	 * If input has been called, triedJump is set to true. 
	 */
	
	void Update() {
		// || Input.GetTouch(0).phase == TouchPhase.Began
		try{
			if(Input.GetKeyDown ("space") /*|| Input.GetTouch(0).phase == TouchPhase.Began*/){
			print ("update notices button press");
			triedJump = true;
			}
		}catch(ArgumentException e){
			Debug.Log("An exception is thrown, this is however only because where are using the to different inputs in the update method");
		}
	}
	
	/*
	 * Physics related updates are placed inside this update. 
	 */

	void FixedUpdate () {
		Jump ();  
		if (transform.localPosition.x < 0) {
			endGameScreen();
		}
	}

	bool canDoubleJump(){
		return jumpCount < 2;
	}

	/*
	 * Jump method. First checks if user tried to jump by pressing space. 
	 * Then goes on to check if the user was on the ground while this action took place.
	 * it also checks if double jump is possible via the canDoubleJump method. If so, rb gets manipulated again.
     *
	 */ 

	void Jump(){
		if (triedJump) {
			if (onGround) {
				rb.velocity = new Vector3 (rb.velocity.x, 0);
				rb.AddForce (new Vector3 (0, jumpHeight));
				jumpCount++;
				onGround = false;
			} else if (canDoubleJump ()) {
				rb.velocity = new Vector3 (rb.velocity.x, 0);
				rb.AddForce (new Vector3 (0, jumpHeight));
				jumpCount++;
			}
			triedJump = false;
		}
	}
	
	/*
	 * Checks if this object has collided with the gameObject with tag "ground" ie the ground object.
     *
	 */ 

	void OnCollisionEnter(Collision coll){
		if (coll.gameObject.tag == "ground") {
			onGround = true;
			jumpCount = 0;
		}
		if (coll.gameObject.tag == "coin") {
			coinScore++;
			print (coinScore);
		}
		if (coll.gameObject.tag == "obstacle") {
			endGameScreen();
		}
		if (coll.gameObject.tag == "finishedObstacle") {
			Coin.updateCoinScore("+", coinScore);
			endGameScreen();
		}
	}

	void endGameScreen(){
		Time.timeScale = 0f;
		endGameCanvas.SetActive (true);
	}
}
	