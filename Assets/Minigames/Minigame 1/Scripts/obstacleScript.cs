using UnityEngine;
using System.Collections;

public class obstacleScript : MonoBehaviour {


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.localPosition.x < -5f) {
			print("hej");
			Destroy(this.gameObject);
		}
		float translate = -Time.deltaTime * 1.3f;
		
		transform.Translate (translate * 2, 0, 0);
	}
}
