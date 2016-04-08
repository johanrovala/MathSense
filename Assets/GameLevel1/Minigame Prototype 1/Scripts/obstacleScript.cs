using UnityEngine;
using System.Collections;

public class obstacleScript : MonoBehaviour {

	/*
	 * We will implement randomized positions for the obstacles later on 
	 * Implementation has started.
	 * 
	 * 
	 * Basically we want to load all the ground prefabs and load one obstacle on one of them. 
	 * No more than one obstacle can be placed on a ground prefab. 
	 * As the obstacle leaves the screen, it will be placed on a random position on the base
	 * of the ground prefab.
	 */
	

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
