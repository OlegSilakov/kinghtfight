using UnityEngine;
using System.Collections;

public class Defence : MonoBehaviour {

	private GameObject _selectedBodyPart;
	public GameObject selectedBodyPart {
		set {
			Debug.Log("triam");
			this._selectedBodyPart = value;
		}
		get {
			return this._selectedBodyPart;
		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
