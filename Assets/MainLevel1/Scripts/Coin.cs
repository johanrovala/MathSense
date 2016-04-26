using UnityEngine;
using System.Collections;

public class Coin{

	public static int coinScore;

	public static void updateCoinScore(int n) {
		coinScore += n;
	}
		
	public static int getCoinScore() {
		return coinScore;
	}

}
