﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;



public class Clue : MonoBehaviour{
		

	public int cost;

	public Sprite clueSprite;
	public Sprite clueTransitionSprite;

	private Texture2D texture;
	private Texture2D textureTransition;

	private Button button;
	private int id;

	public bool test = false;


	private SpriteRenderer spriteRenderer;
	private Sprite sprite;

	public Clue (int cost, SpriteRenderer spriteRenderer, Sprite sprite, Button button){
		this.cost = cost;
		this.button = button;
		this.spriteRenderer = spriteRenderer;
		this.sprite = sprite;
		System.Random rnd = new System.Random ();
		id = rnd.Next (1, 100);
	}

	public void activate(){

		// If player has sufficient amount of coins, go ahead and update the coinscore and the sprite for the clue
		Debug.Log (Coin.getCoinScore());
		if (Coin.getCoinScore() >= this.cost){
			Coin.updateCoinScore("-", this.cost);
			Debug.Log ("Amount of coins after purchase: " + Coin.getCoinScore());
			spriteRenderer.sprite = sprite;
			test = true;
			//button.image.sprite = clueTransitionSprite;
		}

		// if not, display this fancy debug message.
		else if(Coin.getCoinScore() < this.cost){
			Debug.Log("insufficient amount of coins. Image displaying this will be implemented shortly!");
		}
	}

	public  bool isActivated(){
		return test;
	}

	public int getId(){
		return this.id;
	}

	public SpriteRenderer getSprite(){
		return this.spriteRenderer;
	}

	public void destroyThis(){
		Destroy (this.spriteRenderer);	
	}

	public void acknowledgeMainLevel(){
		// since we are going to have a listview and also the posibility to change 
		// the look of the equation in the mainlevel, i suggest we have a method of some sort (not just addToListView) 
		// that acknowledges the main level of some changes needed to be made. 
	}



}
