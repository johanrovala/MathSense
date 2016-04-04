using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class equationHandler : MonoBehaviour {

	public static Equation equation = new Equation(10, "x + 5 = ?");
	Text text; 

	// Use this for initialization
	void Start () {
		text = GetComponent <Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		text.text = equation.getEquation ();
	}
}
