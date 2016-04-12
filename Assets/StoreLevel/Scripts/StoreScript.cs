using UnityEngine;
using System.Collections;

public class StoreScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void LoadStage() {
		print ("button works");
		Level level = new Level (19, "testLudde");
		level.launchLevel ();	
	}
}
