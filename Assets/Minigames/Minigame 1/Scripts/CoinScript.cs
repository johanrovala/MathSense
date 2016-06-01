using UnityEngine;
using System.Collections;

public class CoinScript : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		float translate = -Time.deltaTime * 1.3f;
		
		transform.Translate (translate*2, 0, 0);
	}

	void OnCollisionEnter(Collision coll){
		if (coll.gameObject.tag == "character") {
			print ("collided with player");
			gameObject.SetActive(false);
		}
	
	}
}
