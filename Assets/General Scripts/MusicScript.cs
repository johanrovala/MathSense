using UnityEngine;
using System.Collections;

public class MusicScript : MonoBehaviour {

	public AudioSource song;

	// Use this for initialization
	void Awake () {
	//	if (!audioBegin) {
	//		song.Play();
			//song = new AudioSource ();
			//song.clip = GameObject.Find ();
			DontDestroyOnLoad(song);
	//		audioBegin = true;
	//	}
	}

/*	public static void Pause(){
		song.Pause ();
	}

	public static void Play() {
		song.Play ();
	}

	/*void Update () {
		if(!song.isPlaying){
			song.Play();
		}
	}*/
}
