using UnityEngine;
using System.Collections;

public class LumberJack : MonoBehaviour {
	public double myTimer = 10.0;
	public double workTimer;
	public GUISkin mySkin;
	// Use this for initialization
	void Start () {
		workTimer = myTimer;
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnGUI() {
		GUI.skin = mySkin;
		if (workTimer > 0) {
			workTimer -= Time.deltaTime;
			GUI.Label(new Rect (Screen.width / 2, Screen.height / 2 - 50, 300, 300), ((int)workTimer).ToString ());
		}
		if (workTimer <= 0) {
			GUI.Label(new Rect (Screen.width / 2 - 100, Screen.height / 2 - 50, 300, 300), "Вы закончили рубить лес!");

			if (GUI.Button(new Rect (Screen.width / 2 - 200, Screen.height / 2, 200, 100), "Заново")) {
				workTimer = myTimer;
			}
			if (GUI.Button(new Rect(Screen.width / 2, Screen.height / 2, 200, 100), "Выйти")) {
			
			}
		}
	}

	void chopWood() {
	
	}
}
