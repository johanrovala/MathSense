﻿using UnityEngine;
using System.Collections;


public class BackScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void LoadStageBack(){
		Application.LoadLevel ("StoreScene");
		Time.timeScale = 1f;
	}
}