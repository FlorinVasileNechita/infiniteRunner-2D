using UnityEngine;
using System.Collections;

public class PlayerScore : MonoBehaviour {
	public GUISkin theSkin = null;

	public static int score = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// When colliding with Coin add to score and destroy Coin
	void OnTriggerEnter2D (Collider2D other) {
		if (other.tag == "Coin") {
			score += 10;
			Destroy (other.gameObject);
		}
		
	}
	// Score GUI
	void OnGUI () 
	{
		GUI.skin = theSkin;
		GUI.color = Color.black;
		// Tappy plane example
		//GUILayout.Label(" Score: ");

		// GUI Label (width, height, x ,y)
		GUI.Label (new Rect (Screen.width / 2 - 150 - 18, 0, 400, 400), "SCORE:" + score);
	}
}
