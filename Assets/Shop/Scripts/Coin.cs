using UnityEngine;
using System.Collections;

public class Coin{

	public static int coinScore;

	public static void updateCoinScore(string s, int n) {
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
