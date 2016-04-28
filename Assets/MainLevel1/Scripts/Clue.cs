using UnityEngine;
using System.Collections;
using UnityEngine.UI;



public class Clue{
		

	public int cost;

	public Sprite clueSprite;
	public Sprite clueTransitionSprite;

	private Texture2D texture;
	private Texture2D textureTransition;

	private Button button;

	public Clue (int cost, string texturePath, string textureTransitionPath, Button button){
		this.cost = cost;
		this.button = button;

		// first sprite
		texture = GameObject.Instantiate (Resources.Load (texturePath)) as Texture2D;
		Rect rec = new Rect (0, 0, texture.width, texture.height);
		clueSprite = Sprite.Create (texture, rec, new Vector2 (0, 0), 1);

		button.image.sprite = clueSprite;

		// transition sprite
		textureTransition = GameObject.Instantiate (Resources.Load (textureTransitionPath)) as Texture2D;
		Rect rec2 = new Rect (0, 0, textureTransition.width, textureTransition.height);
		clueTransitionSprite = Sprite.Create (textureTransition, rec2, new Vector2 (0, 0), 1);

	}

	public void activate(){
		Debug.Log (Coin.getCoinScore());
		if (Coin.getCoinScore() >= this.cost){
			Coin.updateCoinScore("-", this.cost);
			Debug.Log (Coin.getCoinScore());
			button.image.sprite = clueTransitionSprite;
		}
		else if(Coin.getCoinScore() < this.cost){
			Debug.Log("insufficient amount of coins. Image displaying this will be implemented shortly!");
		}
	}
	



}
