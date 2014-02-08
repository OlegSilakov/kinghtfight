using UnityEngine;
using System.Collections;

public class PlayerBodyPartDefence : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseUpAsButton () {

		GameObject player = GameObject.Find("Player");
		Defence defence = player.GetComponent("Defence") as Defence;

		defence.selectedBodyPart = this.gameObject;
	}
}
