using UnityEngine;
using System.Collections;
using UnityEngine.UI;



public class Clue{

	public int cost;

	public Sprite clueSprite;
	public Sprite clueTransitionSprite;

	private Texture2D texture;
	private Texture2D textureTransition;

	private int id;

	public bool test = false;


	private SpriteRenderer spriteRenderer;
	private Sprite sprite;

	public Clue (int cost, SpriteRenderer spriteRenderer, Sprite sprite, Button button){
		this.cost = cost;
		this.spriteRenderer = spriteRenderer;
		this.sprite = sprite;
		System.Random rnd = new System.Random ();
		id = rnd.Next (1, 100);
	}

	public void activate(int i){

		// If player has sufficient amount of coins, go ahead and update the coinscore and the sprite for the clue
		if (Coin.getCoinScore() >= this.cost){
			Coin.updateCoinScore("-", this.cost);
			spriteRenderer.sprite = sprite;
			test = true;
			ClueMaster.activateClue (i);
		}

		// if not, display this fancy debug message.
		else if(Coin.getCoinScore() < this.cost){
			Debug.Log("insufficient amount of coins. Image displaying this will be implemented shortly!");
		}
	}

	public void keepActivated(){
		spriteRenderer.sprite = sprite;
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
}
