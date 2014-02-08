using UnityEngine;
using System.Collections;

public class LumberJack : MonoBehaviour {
	public double myTimer = 10.0;
	public GUISkin mySkin;
	public Texture reload;
	public Texture cancel;

	double workTimer;

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
			GUI.Label (new Rect (Screen.width / 2 - 150, Screen.height / 2 - 150, 300, 300), ((int)workTimer).ToString ());
		}
		if (workTimer <= 0) {
			GUI.Label (new Rect (Screen.width / 2 - 150, Screen.height / 2 - 150, 300, 300), "You finished chop-chop!");

			if (GUI.Button(new Rect (Screen.width / 2 - 125, Screen.height / 2 + 40, 100, 100), reload)) {
				workTimer = myTimer;
			}
			if (GUI.Button(new Rect(Screen.width / 2 + 25, Screen.height / 2 + 40, 100, 100), cancel)) {
				Application.LoadLevel(0);
			}
		}
	}

	void chopWood() {
	
	}
}
