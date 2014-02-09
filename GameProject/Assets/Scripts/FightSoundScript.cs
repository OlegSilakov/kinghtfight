using UnityEngine;
using System.Collections;

public class FightSoundScript : MonoBehaviour {
	public AudioClip fightSound;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void PlaySound() {
		SoundPlayer player = SoundPlayer.getInstance ();
		player.play (fightSound);	
	}
}
