using UnityEngine;
using System.Collections;

public class God : MonoBehaviour {

	private VirtualEnemy virtualEnemy;
	private bool walkToFight;

	private GameObject player;
	private GameObject enemy;

	// Use this for initialization
	void Start () {
		player = GameObject.Find("Player");
		enemy = GameObject.Find("Enemy");

		virtualEnemy = new VirtualEnemy ();
		walkToFight = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (walkToFight) {
			float distance = Mathf.Abs(player.transform.position.x - enemy.transform.position.x);
			if (distance > 3) {
				player.transform.position += new Vector3(0.01f,0,0);
				enemy.transform.position -= new Vector3(0.01f,0,0);
			}
		}
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


		player.GetComponent<Animator>().SetTrigger("Walk");
		enemy.GetComponent<Animator>().SetTrigger("Walk");

		walkToFight = true;
	}
}
