using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {
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
		// Puts background inside GUI
		GUI.DrawTexture(new Rect(0,0,Screen.width,Screen.height),gameOverTexture);
		//GUI.skin = gameOverSkin;
		// GUI Button (width, height, x ,y)
		if (GUI.Button(new Rect(Screen.width / 2 - 150 - 18, Screen.height /2, 200, 25),"Play"))
		{
			PlayerPrefs.SetInt("previousLevel", Application.loadedLevel );
			Application.LoadLevel(2);
			// Application.LoadLevel ("levels");
		}
		if (GUI.Button(new Rect(Screen.width / 2 - 150 - 18, Screen.height /2 + 25, 200, 25),"Settings"))
		{
			PlayerPrefs.SetInt("previousLevel", Application.loadedLevel );
			Application.LoadLevel ("Settings");
		}
		if (GUI.Button(new Rect(Screen.width / 2 - 150 - 18, Screen.height /2 + 50, 200, 25),"Exit"))
		{
			Application.Quit();
		}
	}
}
