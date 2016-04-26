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
		Application.LoadLevel ("minigame_1");
		Time.timeScale = 1f;
	}
}
