using UnityEngine;
using System.Collections;

public class PlayerProgress : MonoBehaviour {

	/*// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}*/

	public void savePoints(int points) {
		PlayerPrefs.SetInt ("player", points);
	}

	public int getPoints() {
		if (!PlayerPrefs.HasKey ("player")) {
			return 200;
		} else {
			return PlayerPrefs.GetInt("player");
		}
	}

}
