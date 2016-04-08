using UnityEngine;
using System.Collections;

public class storeScript : MonoBehaviour {

	public GameObject storeCanvas;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void ShowStore(){
		storeCanvas.SetActive (true);
	}
	
	public void HideStore(){
		storeCanvas.SetActive (false);
	}
	
	public void LoadStage() {
		print ("button works");
		Level level = new Level (19, "testLudde");
		level.launchLevel ();	
	}
}
