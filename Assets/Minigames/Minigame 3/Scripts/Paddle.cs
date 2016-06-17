using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {

	/*
	 * Since this minigame was first written in using a two year old version of the Unity C# API, some of the physics 
	 * implementation does not function as we had hoped. Due to time restraints we opted to make quick fixes regarding 
	 * some deprecated functions, switching them out for what Unity had suggested. The result of this is that the ball 
	 * bounces in an awkward way.
	 * 
	 * Ayaz has also not yet implemented the touch functionality for this minigame. I myself have not had time since i've 
	 * been busy fixing everything else.
	 */ 

	public bool autoPlay = false;

	public float minX, maxX;
	public float speed = 0.1f;

	private Ball ball;
	
	void Start () {
		ball = GameObject.FindObjectOfType<Ball>();
	}
		
	// Update is called once per frame
	void Update () {
		if (!autoPlay) {
			MoveWithMouse();
			if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved){
				Vector2 touchPosition = Input.GetTouch(0).deltaPosition;
				this.transform.Translate(-touchPosition.x * speed, -touchPosition.y * speed, 0);
			}


		} else {
			AutoPlay();
		}
	}
	
	void AutoPlay() {
		Vector3 paddlePos = new Vector3 (0.5f, this.transform.position.y, 0f);
		Vector3 ballPos = ball.transform.position;
		paddlePos.x = Mathf.Clamp(ballPos.x, minX, maxX);
		this.transform.position = paddlePos;
	}
	
	void MoveWithMouse () {
		Vector3 paddlePos = new Vector3 (0.5f, this.transform.position.y, 0f);
		float mousePosInBlocks = Input.mousePosition.x / Screen.width * 16;
		paddlePos.x = Mathf.Clamp(mousePosInBlocks, minX, maxX);
		this.transform.position = paddlePos;
	}


}
