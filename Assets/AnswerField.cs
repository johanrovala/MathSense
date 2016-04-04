using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AnswerField : MonoBehaviour {


	InputField answerField;
	public static int answer;

	// Use this for initialization
	/*void Start () {
		answerField = GetComponent<InputField> ();
		answer = int.Parse(answerField.text);
	}*/

	public void getInput(){
		answerField = GetComponent<InputField> ();
		answer = int.Parse(answerField.text);
		print (answer);
	}
}
