using UnityEngine;
using System.Collections;

public class StartScene : MonoBehaviour {

    public Sprite[] sprites;
    private GameObject number;
    private double interval;

    double myTimer = 2.5;
    // Use this for initialization
    void Start() {
        number = new GameObject();
        var render = number.AddComponent("SpriteRenderer") as SpriteRenderer;
        interval = myTimer / sprites.Length;

    }

    // Update is called once per frame
    void Update() {
        if (myTimer > 0) {
            myTimer -= Time.deltaTime;
            var render = number.GetComponent("SpriteRenderer") as SpriteRenderer;
            if (render != null) {
                render.sprite = sprites[(int)(myTimer/interval)];
                Debug.Log("index: " + ((int)(myTimer / interval)).ToString());
            }
        }
        if (myTimer <= 0) {
            number.SetActive(false);
            Debug.Log("GAME OVER");
        }
    }
}
