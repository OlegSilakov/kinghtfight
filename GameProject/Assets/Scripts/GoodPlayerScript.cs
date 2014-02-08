using UnityEngine;
using System.Collections;

public class GoodPlayerScript : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnMouseEnter () {
		Debug.Log("xxx");
		this.transform.FindChild("Head_pain").gameObject.SetActive(true);
	}
	
	void OnMouseExit () {
		this.transform.FindChild("Head_pain").gameObject.SetActive(false);
	}
}
