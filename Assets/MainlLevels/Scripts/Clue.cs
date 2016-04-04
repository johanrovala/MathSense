using UnityEngine;
using System.Collections;

public class Clue{
		
	private int cost;
	private int clue;

	public Clue (int clue, int cost){
		this.clue = clue;
		this.cost = cost;
	}

	public int getCost(){
		return cost;
	}

	public int getClue(){
		return clue;
	}

}
