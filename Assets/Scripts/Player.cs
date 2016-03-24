using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	// The force which is added when the player jumps
	public Vector2 jumpForce = new Vector2(0, 350);
	bool grounded = true;

	// Moves runner (should I use this or transform.translate?)
	// public Vector2 velocity = new Vector2(5, 0); 
	
	public float gameOverY;

	int jumpCount = 0;

	// Use this for initialization
	void Start () {
		PlayerScore.score = 0;
	}
	
	// Update is called once per frame
	void Update () {
		//Move player
		transform.Translate(6f * Time.deltaTime, 0f, 0f);

		if (jumpCount <= 2 && grounded == true && Input.GetKeyDown (KeyCode.UpArrow)) {
			GetComponent<Rigidbody2D>().AddForce (jumpForce);
			jumpCount ++;
			if (jumpCount == 2){		
				grounded = false;
			}
		}
		else if(jumpCount > 2){ jumpCount =0;}

		// Game over by falling
		if(transform.localPosition.y < gameOverY) {
			// Restart level
			//Application.LoadLevel(Application.loadedLevel);
			// Save the id of this scene (maybe move this to script for camera)
			PlayerPrefs.SetInt("previousLevel", Application.loadedLevel );
			// Go to Game Over menus
			Application.LoadLevel ("GameOver");

		} 
	}
	
	// When runner collides he can jump twice again
	void OnCollisionEnter2D(Collision2D collider) 
	{
		if (collider.gameObject.tag == "groundBlock") {
			grounded = true;
			jumpCount = 0;
		}

		if (collider.gameObject.tag == "spiky") {
			PlayerPrefs.SetInt("previousLevel", Application.loadedLevel );
			// Go to Game Over menus
			Application.LoadLevel ("GameOver");

				}

		if (collider.gameObject.tag == "goal") {
			Application.LoadLevel ("GameWin");
		}

	}

}
