using UnityEngine;
using System.Collections;

public class God : MonoBehaviour {

	private VirtualEnemy virtualEnemy;

	// Use this for initialization
	void Start () {
		virtualEnemy = new VirtualEnemy ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Fight() {
		string enemyAttack = virtualEnemy.getAttackPartOfBody ();
		string enemyDefence = virtualEnemy.getDefencePartOfBody ();
		string playerAttack = this.getAttackPartOfBody ();
		string playerDefence = this.getDefencePartOfBody ();

		this.startFightAnimation();
	}

	private string getAttackPartOfBody(){
		return "legs";
	}
	
	private string getDefencePartOfBody(){
		return "head";
	}

	private void startFightAnimation(){
		GameObject player = GameObject.Find("Player");
		GameObject enemy = GameObject.Find("Enemy");

		player.GetComponent<Animator>().SetTrigger("Walk");
		enemy.GetComponent<Animator>().SetTrigger("Walk");

	}
}
