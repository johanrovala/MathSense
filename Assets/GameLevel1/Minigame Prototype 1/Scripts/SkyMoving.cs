using UnityEngine;
using System.Collections;

public class SkyMoving : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (transform.localPosition.x > 50f) {
			transform.localPosition = new Vector2(-31.8f, 0.8f);
		}
		
		transform.Translate (Time.deltaTime/2, 0, 0);
	}
}
