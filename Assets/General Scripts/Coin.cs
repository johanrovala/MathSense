using UnityEngine;
using System.Collections;

public class Coin{

	public static int coinScore = 0;

	public static void updateCoinScore(string s, int n) {

		Debug.Log ("Updating coinscore");

		if(s.Equals("+")){
			coinScore += n;	
		}else if(s.Equals("-")){
			coinScore -= n;
		}

		// make a third condition in case something crazy happens
	
	}
		
	public static int getCoinScore() {
		return coinScore;
	}

}
