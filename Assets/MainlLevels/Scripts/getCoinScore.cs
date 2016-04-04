using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class getCoinScore : MonoBehaviour {

	// check if it is possible to update the coinscore only in the start method. This depends on if the scene is actually started from 
	// scratch again after for example a minigame has been played. 


	public static int coinScore;
	Text text; 

	// Use this for initialization
	void Start () {
		coinScore = characterScript.coinScore;
		text = GetComponent <Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		text.text = "# " + coinScore;
	}
}
