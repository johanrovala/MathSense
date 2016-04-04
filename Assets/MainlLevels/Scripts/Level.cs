using UnityEngine;
using System.Collections;

public class Level{

	private int cost;
	private string path;

	public Level (int cost, string path){
		this.cost = cost;
		this.path = path;
	}

	public int getCost(){
		return this.cost;
	}

	public string getPath(){
		return this.path;
	}

	public void launchLevel(){
		Application.LoadLevel (path);
	}



	

}
