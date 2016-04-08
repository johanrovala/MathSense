using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class StartScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Clue clue1 = new Clue ("Five", 10);
		Variable var1 = new Variable ("AppleVariable", clue1);
		Clue clue2 = new Clue ("Ten", 10);
		Variable var2 = new Variable ("BananaVariable", clue2);
		List<Variable> varList = new List<Variable> ();
		varList.Add (var1);
		varList.Add (var2);

	}

	void Update() {
		
	}
}
