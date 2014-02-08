using UnityEngine;
using System.Collections;

public class VirtualEnemy : MonoBehaviour {
	private int health;
	private ArrayList partsOfBody = new ArrayList() { "head", "body", "hands", "legs"};

	/*// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}*/

	public string getAttackPartOfBody(){
		int val = (int)(Random.value * 4);
		Debug.Log (val);
		return partsOfBody[val].ToString();
	}

	public string getDefencePartOfBody(){
		int val = (int)(Random.value * 4);
		return partsOfBody[val].ToString();
	}

}
