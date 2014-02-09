using UnityEngine;
using System.Collections;

public class PauseScript : MonoBehaviour {
	public Texture pauseTexture;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI() {
		if (GUI.Button (new Rect (Screen.width / 2 - Screen.width / 15, 0, Screen.width / 10, Screen.height / 8), pauseTexture)) {
			Application.LoadLevel(0);
		}
	}
}
