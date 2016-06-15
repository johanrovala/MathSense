using UnityEngine;
using System.Collections;

public class BackAndRestartScript : MonoBehaviour{


	public void Back(){
		Debug.Log ("Should return to store scene");
		ButtonSound.playSound ();
		BackgroundMusic.UnPause();
		Application.LoadLevel ("StoreScene");
		Time.timeScale = 1f;
	}

	public void Restart(int i){
		Debug.Log ("Should restart level");
		ButtonSound.playSound ();
		if (i.Equals (0)) {
			BackgroundMusic.UnPause();
			Application.LoadLevel ("minigame_1");
		}else if (i.Equals (1)) {
			BackgroundMusic.UnPause();
			Application.LoadLevel ("level1");
		}else if (i.Equals (2)) {
			BackgroundMusic.UnPause();
			Application.LoadLevel ("Level_01");
		}
		Time.timeScale = 1f;
	}

}
