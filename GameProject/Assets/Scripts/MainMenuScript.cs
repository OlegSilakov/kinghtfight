using UnityEngine;
using System.Collections;

public class MainMenuScript : MonoBehaviour {

	public GUISkin mySkin;
	public Texture fightButton;
	public Texture chopButton;
	public Texture exitButton;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI() {
		GUI.skin = mySkin;
		if (GUI.Button(new Rect(Screen.width / 2 - 230, Screen.height / 2 - 40, 140, 80), fightButton)) {
			Application.LoadLevel(1);
		}
		if (GUI.Button(new Rect(Screen.width / 2 - 70, Screen.height / 2 - 40, 140, 80), chopButton)) {
			Application.LoadLevel(2);
		}
		if (GUI.Button(new Rect(Screen.width / 2 + 90, Screen.height / 2 - 40, 140, 80), exitButton)) {
			Application.Quit();
		}
	}
}
