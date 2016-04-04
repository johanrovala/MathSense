using UnityEngine;
using System.Collections;

public class Equation{

	private int answer;
	private string equation;

	public Equation(int answer, string equation){
		this.answer = answer;
		this.equation = equation;
	}

	public int getAnswer(){
		return this.answer;
	}

	public string getEquation(){
		return this.equation;
	}

	public void setEquation(string eq){
		this.equation = eq;
	}

}
