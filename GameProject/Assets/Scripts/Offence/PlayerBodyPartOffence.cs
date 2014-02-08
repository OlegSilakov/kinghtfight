using UnityEngine;
using System.Collections;

public class PlayerBodyPartOffence : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseUpAsButton () {
		GameObject player = GameObject.Find("Enemy");
		Offence offence = player.GetComponent("Offence") as Offence;
		
		offence.selectedBodyPart = this.gameObject;
	}
}
