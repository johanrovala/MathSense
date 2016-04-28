using UnityEngine;
using System.Collections;

public class BackAndRestartScript : MonoBehaviour{

	public void Back(){
		Application.LoadLevel ("StoreScene");
		Time.timeScale = 1f;
	}

	public void Restart(){
		Application.LoadLevel ("mingame_1");
		Time.timeScale = 1f;
	}

}
