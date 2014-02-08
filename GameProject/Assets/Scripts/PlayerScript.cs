using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnMouseEnter () {
		this.transform.FindChild("Head_pain").gameObject.SetActive(true);
	}

	void OnMouseExit () {
		this.transform.FindChild("Head_pain").gameObject.SetActive(false);
	}
}
