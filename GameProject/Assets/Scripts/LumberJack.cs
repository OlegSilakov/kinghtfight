using UnityEngine;
using System.Collections;

public class LumberJack : MonoBehaviour {
	public double myTimer = 10.0;
	public GUISkin mySkin;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnGUI() {
		GUI.skin = mySkin;
		if (myTimer > 0) {
			myTimer -= Time.deltaTime;
			GUI.Label (new Rect (Screen.width / 2, Screen.height / 2, 300, 300), ((int)myTimer).ToString ());
		}
		if (myTimer <= 0) {
			GUI.Label (new Rect (Screen.width / 2, Screen.height / 2, 300, 300), "Вы закончили рубуить лес!");
		}
	}

	void chopWood() {
	
	}
}
