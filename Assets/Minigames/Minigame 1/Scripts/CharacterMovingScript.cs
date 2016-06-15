using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CharacterMovingScript : MonoBehaviour {

	public AudioSource audioSource;
	public AudioClip jump;
	public AudioClip fruit;
	public AudioClip hurt;
	public AudioClip win;

	public GameObject character;
	public GameObject endGameCanvas;
	Vector2 v2;

	private int coinScore = 0;
	private Text coinText;

	private Rigidbody2D rb;

	public float firstJumpHeight;
	public float secondJumpHeight;

	private bool triedJump = false;
	private bool onGround = true;
	private int jumpCount = 0;
	

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		coinText = GameObject.Find ("CoinText").GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		v2 = new Vector2 (Time.deltaTime * 3f, 0);
		character.transform.Translate (v2);

		if (Input.GetKeyDown("space")){
			Debug.Log ("Spacebar pressed");
			triedJump = true;

		}

	}

	void FixedUpdate(){
		Jump ();
	}

	
	bool canDoubleJump(){
		return jumpCount < 2;
	}


	void Jump(){
		if (triedJump) {
			if (onGround) {
				rb.AddForce (Vector2.up * firstJumpHeight);
				audioSource.clip = jump;
				audioSource.Play ();
				jumpCount++;
				onGround = false;
			} else if (canDoubleJump ()) {
				audioSource.clip = jump;
				audioSource.Play ();
				rb.AddForce (Vector2.up * firstJumpHeight);
				jumpCount++;
			}
			triedJump = false;
		}
	}


	void OnCollisionEnter2D (Collision2D coll){
		if (coll.gameObject.tag == "ground"){
			onGround = true;
			jumpCount = 0;
		}
		if (coll.gameObject.tag == "Fruit") {
			audioSource.clip = fruit;
			audioSource.Play ();
			Destroy(coll.gameObject);
			coinScore++;
			updateCoinText();
		}
		if (coll.gameObject.tag == "DeathZone") {
			BackgroundMusic.Pause();
			audioSource.clip = hurt;
			audioSource.Play ();
			endGameScreen();
		}
		if (coll.gameObject.tag == "Finish") {
			endGameScreen();
			Coin.updateCoinScore("+", coinScore);
			BackgroundMusic.Pause();
			audioSource.clip = win;
			audioSource.Play ();
		}
	}

	private void updateCoinText() {
		coinText.text = coinScore.ToString();
	}

	private void endGameScreen(){
		Time.timeScale = 0f;
		endGameCanvas.SetActive (true);
	}
}
