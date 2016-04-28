using UnityEngine;
using System.Collections;

public class Level{

	private int reward;
	private string path;

	public Level (int reward, string path){
		this.reward = reward;
		this.path = path;
	}

	public int getCost(){
		return this.reward;
	}

	public string getPath(){
		return this.path;
	}

	public void launchLevel(){
		Application.LoadLevel (path);
	}
	



	

}
