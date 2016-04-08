using UnityEngine;
using System.Collections;
using System.Collections.Generic;

abstract public class Equation{

	public List<Variable> variableList;
	public List<Operator> operatorList;
	private int answer;

	public Equation(List<Variable> variableList, List<Operator> operatorList, int answer){
		this.variableList = variableList;
		this.operatorList = operatorList;
		this.answer = answer;
	}

	public void setAnswer(int answer){
		this.answer = answer;
	}

	public int getAnswer(){
		return answer;
	}
		
	public void setVariableList(List<Variable> n){
		variableList = n;
	}

	public void setOperatorList(List<Operator> n){
		operatorList = n;
	}

	public List<Variable> getVariableList(){
		return variableList;
	}

	public List<Operator> getOperatorList(){
		return operatorList;
	}

	public Variable getVariable(int n){
		return variableList[n];
	}

	public Operator getOperator(int n){
		return operatorList[n];
	}
}
