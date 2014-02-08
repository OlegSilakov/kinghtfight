using UnityEngine;
using System.Collections;

public class LumberJack : MonoBehaviour {
	public double myTimer = 10.0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(myTimer > 0){
			myTimer -= Time.deltaTime;
		}
		if(myTimer <= 0){
			Debug.Log("GAME OVER");
		}
	}

	void OnGUI() {
		GUI.Label (new Rect (Screen.width / 2, Screen.height / 2, 300, 300), ((int)myTimer).ToString());
	}

	void chopWood() {
	
	}
}
