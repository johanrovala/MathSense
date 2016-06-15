using UnityEngine;
using System.Collections;

public class GhostScript : MonoBehaviour {

	public GameObject ghost;
	private const int maxY = 3;
	private const int minY = 2;
	private float speed = 1.5f;
	Vector2 move;

	// Use this for initialization
	void Start () {

	}


	/* 
	 * Known bug where the ghost object sometimes moves a bit to far up, or down. In this case the update function gets called before
	 * the ghost has surpassed the minY or decreased below the maxY. This makes the ghost get stuck in an infinite loop where speed = -speed indefinately.
	 * A move from pointa-to-pointb implementation will be fixed if time is su
	 */ 
	
	// Update is called once per frame
	void Update () {
		move = new Vector2 (0, Time.deltaTime * speed);
		ghost.transform.Translate (move);
		if (ghost.transform.position.y >= maxY) {
		//	Debug.Log ("speed = -speed");
			speed = -speed;
		} 
		else if (ghost.transform.position.y <= minY) {
		//	Debug.Log ("-speed = speed");
			speed = -speed;
		}
	}


}
