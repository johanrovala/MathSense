using UnityEngine;
using System.Collections;

public class RestartScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void LoadStageRestart(){
		Application.LoadLevel ("testLudde");
		Time.timeScale = 1f;
	}
}
