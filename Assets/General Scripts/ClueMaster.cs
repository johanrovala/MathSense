using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;



public class ClueMaster : MonoBehaviour {

	public static bool firstClueActive = false;
	public static bool secondClueActive = false;


	public static void activateClue(int i){
		if (i == 0) {
			firstClueActive = true;
		}else if (i == 1){
			secondClueActive = true;
		}
	}

}
