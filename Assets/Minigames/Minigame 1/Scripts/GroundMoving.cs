using UnityEngine;
using System.Collections;

public class GroundMoving : MonoBehaviour {

	// will try to implement a way to get the starting position automatically. 
	// preferably by getting the exact x.values from the ground game objects 
	float startPos;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (transform.localPosition.x < -10f) {
			transform.localPosition = new Vector3(25f, -1f, -1f);
		}
		float translate = -Time.deltaTime * 1.3f;

		transform.Translate (translate*2, 0, 0);

	}
}
