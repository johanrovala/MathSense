using UnityEngine;
using System.Collections;

public class Clue{
		
	private int cost;
	private GameObject numberObject;

	public Clue (string objectName, int cost){
		this.cost = cost;
		numberObject = Resources.Load (objectName) as GameObject;
	}

	public int getCost(){
		return cost;
	}



}
