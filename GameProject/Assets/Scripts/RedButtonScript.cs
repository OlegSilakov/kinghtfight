using UnityEngine;
using System.Collections;

public class RedButtonScript : MonoBehaviour {
	public GameObject player;
	public GameObject enemy;

	Defence defence;
	Offence offence;

	public Texture redButton;
	public GUISkin mySkin;

	private bool fightButtonEnabled;
	private bool oldSelected = false;

	// Use this for initialization
	void Start () {
		offence = enemy.GetComponent<Offence> ();
		defence = player.GetComponent<Defence> ();
	}
	
	// Update is called once per frame
	void Update () {
		bool newSelected = (defence.selectedBodyPart && offence.selectedBodyPart);

		if (newSelected && !oldSelected) {
			fightButtonEnabled = true;
		}
//		else if (!newSelected && oldSelected) {
//			fightButtonEnabled = false;
//		}

		oldSelected = newSelected;
	}

	void OnGUI() {
		if (!fightButtonEnabled) {
			return;
		}
		GUI.skin = mySkin;
		if (defence.selectedBodyPart && offence.selectedBodyPart) {
			float width = Screen.width / 5;
			if (GUI.Button(new Rect (Screen.width / 2 - width/2, Screen.height / 2 - width/2, width, width), redButton)) {
				fightButtonEnabled = false;
				GameObject.Find("God").GetComponent<God>().Fight();
			}
		}
	}
}
