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

		GameObject selectedBodyPart = defence.selectedBodyPart;
		if (selectedBodyPart) {
			SpriteRenderer selectedRender = selectedBodyPart.GetComponent ("SpriteRenderer") as SpriteRenderer;
			selectedRender.color = Color.white;
		}

		defence.selectedBodyPart = this.gameObject;

		SpriteRenderer render = this.gameObject.GetComponent("SpriteRenderer") as SpriteRenderer;
		render.color = Color.green;
	}
}
