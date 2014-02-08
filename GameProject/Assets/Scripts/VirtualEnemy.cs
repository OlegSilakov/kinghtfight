using UnityEngine;
using System.Collections;

public class VirtualEnemy : MonoBehaviour {
	private int health;
	private ArrayList partsOfBody = new ArrayList() { "Head", "Body", "Hand_left", "Hand_right", "Legs"};

	/*// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}*/

	public string getAttackPartOfBody(){
		int val = (int)(Random.value * 5);
		Debug.Log (val);
		return partsOfBody[val].ToString();
	}

	public string getDefencePartOfBody(){
		int val = (int)(Random.value * 5);
		return partsOfBody[val].ToString();
	}

}
