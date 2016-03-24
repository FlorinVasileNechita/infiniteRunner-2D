using UnityEngine;
using System.Collections;

public class Levels : MonoBehaviour {
	public Texture gameOverTexture;
	public GUISkin gameOverSkin;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnGUI()
	{
		// The id of previous level is stored into this variable
		int previousLevel = PlayerPrefs.GetInt( "previousLevel" );
		// Puts background inside GUI
		GUI.DrawTexture(new Rect(0,0,Screen.width,Screen.height),gameOverTexture);
		GUI.skin = gameOverSkin;
		// GUI Button (width, height, x ,y)
		if (GUI.Button(new Rect(Screen.width / 2 - 150 - 18, Screen.height /2, 200, 25),"<--"))
		{
			Application.LoadLevel(previousLevel);
		}
		if (GUI.Button(new Rect(Screen.width / 2 - 150 - 18, Screen.height /2 + 25, 200, 25),"Level 1"))
		{
			Application.LoadLevel ("level1");
		}
	}
}
