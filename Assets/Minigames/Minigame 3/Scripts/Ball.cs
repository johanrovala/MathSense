using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Ball : MonoBehaviour {


	/*
	 * Since this minigame was first written in using a two year old version of the Unity C# API, some of the physics 
	 * implementation does not function as we had hoped. Due to time restraints we opted to make quick fixes regarding 
	 * some deprecated functions, switching them out for what Unity had suggested. The result of this is that the ball 
	 * bounces in an awkward way.
	 */ 
	
	private Paddle paddle;
	private bool hasStarted = false;
	private Vector3 paddleToBallVector;

	private int coinScore;
	private Text coinText;

	// Use this for initialization
	void Start () {
		coinText = GameObject.Find ("CoinText").GetComponent<Text> ();
		paddle = GameObject.FindObjectOfType<Paddle>();
		paddleToBallVector = this.transform.position - paddle.transform.position;
	}
	
	void Update () {
		if (!hasStarted) {
			// Lock the ball relative to the paddle.
			this.transform.position = paddle.transform.position + paddleToBallVector;

				print ("Mouse clicked, launch ball");
				hasStarted = true;
				GetComponent<Rigidbody2D>().velocity = new Vector2 (2f, 10f);

		}
	}
	
	void OnCollisionEnter2D (Collision2D collision) {
		// Ball does not trigger sound when brick is destoyed.
		// Not 100% sure why, possibly because brick isn't there.
		Vector2 tweak = new Vector2 (Random.Range(0f, 0.2f), Random.Range(0f, 0.2f));
		
		if (hasStarted) {	
			//audio.Play();
			GetComponent<Rigidbody2D>().velocity += tweak;
		}

		if (collision.gameObject.tag == "Breakable") {
			coinScore++;
			Debug.Log ("Has hit a brick and the coinScore is: " + coinScore);
			Coin.updateCoinScore ("+", 1);
			updateCoinText();

		}
	}

	private void updateCoinText() {
		coinText.text = coinScore.ToString();
	}
}
