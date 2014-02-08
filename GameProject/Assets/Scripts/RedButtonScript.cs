using UnityEngine;
using System.Collections;

public class RedButtonScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown () {
		this.transform.localScale = new Vector3(0.9f, 0.9f, 1.0f);

	}

	void OnMouseUp () {
		this.gameObject.SetActive(false);
	}
}
