using UnityEngine;
using System.Collections;

public class BackAndRestartScript : MonoBehaviour{


	public void Back(){
		Application.LoadLevel ("StoreScene");
		Time.timeScale = 1f;
	}

	public void Restart(int i){
		if (i.Equals (0)) {
			Application.LoadLevel ("level2");
		}else if (i.Equals (1)) {
			Application.LoadLevel ("level1");
		}else if (i.Equals (2)) {
			Application.LoadLevel ("Level_01");
		}
		Time.timeScale = 1f;
	}

}
