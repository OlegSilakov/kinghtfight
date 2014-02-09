using UnityEngine;
using System.Collections;

public class God : MonoBehaviour {

	private VirtualEnemy virtualEnemy;
	private bool walkToFight;
	private bool endGame;
	private bool walkToInitialPosition;
	private float initialDistance;
	private GameObject player;
	private GameObject enemy;

	private PlayerProgress progress;
	private int enemyPoints = 200;
	private int userPoints;

	// Use this for initialization
	void Start () {
		player = GameObject.Find("Player");
		enemy = GameObject.Find("Enemy");
		initialDistance = Mathf.Abs(player.transform.position.x - enemy.transform.position.x);

		virtualEnemy = new VirtualEnemy ();
		walkToFight = false;
		endGame = false;
		progress = new PlayerProgress();
		userPoints = progress.getPoints ();
		walkToInitialPosition = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (endGame) {
			return;
		}
		if (walkToFight) {
			float distance = Mathf.Abs(player.transform.position.x - enemy.transform.position.x);
			if (distance > 3) {
				player.transform.position += new Vector3(0.03f,0,0);
				enemy.transform.position -= new Vector3(0.03f,0,0);
			}
			else {
				player.GetComponent<Animator>().SetTrigger("Attack");
				enemy.GetComponent<Animator>().SetTrigger("Attack");

				walkToFight = false;
				walkToInitialPosition = true;

			}
		}
		else if (walkToInitialPosition) {
			player.GetComponent<Animator>().ResetTrigger("Attack");
			enemy.GetComponent<Animator>().ResetTrigger("Attack");
			float distance = Mathf.Abs(player.transform.position.x - enemy.transform.position.x);
			if (distance < initialDistance) {
				player.transform.position -= new Vector3(0.03f,0,0);
				enemy.transform.position += new Vector3(0.03f,0,0);
                ResetSelect();
			}
			else {
				player.GetComponent<Animator>().ResetTrigger("Walk");
				enemy.GetComponent<Animator>().ResetTrigger("Walk");
                walkToInitialPosition = false;
            }
		}
	}

    private void ResetSelect() {
        var defence = player.GetComponent<Defence>();
        var offence = enemy.GetComponent<Offence>();
        defence.selectedBodyPart = new GameObject();
        offence.selectedBodyPart = new GameObject();
        defence = enemy.GetComponent<Defence>();
        offence = player.GetComponent<Offence>();
        defence.selectedBodyPart = new GameObject();
        offence.selectedBodyPart = new GameObject();
    }

	public void Fight() {
				string enemyAttack = virtualEnemy.getAttackPartOfBody ();
				string enemyDefence = virtualEnemy.getDefencePartOfBody ();
				string playerAttack = this.getAttackPartOfBody ();
				string playerDefence = this.getDefencePartOfBody ();



				if (playerDefence == enemyAttack) {
						Debug.Log ("User damage  = 0");
				} else {
						switch (enemyAttack) {
						case "head":
								userPoints -= 50;
								break;
						case "body":
								userPoints -= 40;
								break;
						case "legs":
								userPoints -= 30;
								break;
						case "hands":
								userPoints -= 20;
								break;
						}
				}

				if (playerAttack == enemyDefence) {
						Debug.Log ("Enemy damage = 0");
				} else {
						switch (playerAttack) {
						case "head":
								enemyPoints -= 50;
								break;
						case "body":
								enemyPoints -= 40;
								break;
						case "legs":
								enemyPoints -= 30;
								break;
						case "hands":
								enemyPoints -= 20;
								break;
						}
				}

				if (userPoints <= 0) {
						Debug.Log ("You lose");
						progress.savePoints (0);
						endGame = true;
				} else {
					progress.savePoints(userPoints);
				}
				
				if (enemyPoints <= 0) {
					Debug.Log("You win");
					progress.savePoints(userPoints);
					endGame = true;
				}
				


		this.selectByEnemy (enemyAttack, enemyDefence);

		this.startFightAnimation();
	}

	private string getAttackPartOfBody(){
		GameObject selected = player.GetComponent<Defence> ().selectedBodyPart;
		return selected.name;
	}
	
	private string getDefencePartOfBody(){
		GameObject selected = enemy.GetComponent<Offence>().selectedBodyPart;
		return selected.name;
	}

	private void selectByEnemy(string attack, string defence) {
		GameObject selected = player.transform.FindChild(attack).gameObject;
		player.GetComponent<Offence> ().selectedBodyPart = selected;

		selected = enemy.transform.FindChild (defence).gameObject;
		enemy.GetComponent<Defence> ().selectedBodyPart = selected;
	}

	private void startFightAnimation(){

		player.GetComponent<Animator>().SetTrigger("Walk");
		enemy.GetComponent<Animator>().SetTrigger("Walk");

		walkToFight = true;
	}

}
