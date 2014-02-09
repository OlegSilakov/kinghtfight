using UnityEngine;
using System.Collections;

public class HealthObserver : MonoBehaviour {

	public GameObject lifeObjectContainer;

	private LifeObject lifeObject; 
	private Vector3 originScale;
	private Transform healthLine;

	// Use this for initialization
	void Start () {
		lifeObject = lifeObjectContainer.GetComponent ("LifeObject") as LifeObject;

		healthLine = this.transform.FindChild("Health");
		if (healthLine) {
			originScale = healthLine.localScale;
		}

		Debug.Log(healthLine);
	}
	
	// Update is called once per frame
	void Update () {
//		this.transform.position = lifeObjectContainer.transform.position + offset;

		float percentOfHealth = lifeObject.health / 200f;
		percentOfHealth = (percentOfHealth < 0) ? 0 : percentOfHealth;

		if (healthLine) {
			healthLine.localScale = new Vector3(percentOfHealth * originScale.x, originScale.y, originScale.z);
		}
	}
}
