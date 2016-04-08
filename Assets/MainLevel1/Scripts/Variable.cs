using UnityEngine;
using System.Collections;

public class Variable{

	private GameObject variableObject;
	private Clue clue;

	public Variable(string objectName, Clue clue){

		variableObject = Resources.Load (objectName) as GameObject;
		this.clue = clue;
	}

	public Clue getClue(){
		return this.clue;
	}

	public GameObject getVariableObject(){
		return variableObject;
	}
}
