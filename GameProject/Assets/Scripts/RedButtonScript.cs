﻿using UnityEngine;
using System.Collections;

public class RedButtonScript : MonoBehaviour {
	public GameObject player;
	public GameObject enemy;

	Defence defence;
	Offence offence;

	public Texture redButton;
	public GUISkin mySkin;

	private bool fightButtonEnabled = true;

	// Use this for initialization
	void Start () {
		Time.timeScale = 0;
		offence = enemy.GetComponent<Offence> ();
		defence = player.GetComponent<Defence> ();
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnGUI() {
		if (!fightButtonEnabled) {
			return;
		}
		GUI.skin = mySkin;
		if (defence.selectedBodyPart && offence.selectedBodyPart) {
			if (GUI.Button(new Rect (Screen.width / 2 - 40, Screen.height / 2 - 40, 80, 80), redButton)) {
				fightButtonEnabled = false;
				Time.timeScale = 1;
			}
		}
	}
}
