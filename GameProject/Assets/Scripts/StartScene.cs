using UnityEngine;
using System.Collections;

public class StartScene : MonoBehaviour {

    public Sprite[] sprites;
    private GameObject number;
    private double interval;
    private double step = .02d;

    double myTimer = 2.5;
    // Use this for initialization
    void Start() {
        number = new GameObject();
        number.transform.position = new Vector3(0.0f, 0.0f, -5.0f);
        var render = number.AddComponent("SpriteRenderer") as SpriteRenderer;
        interval = myTimer / sprites.Length;

    }

    // Update is called once per frame
    void Update() {
        if (sprites == null)
            return;
        if (sprites.Length < 1)
            return;
        if (myTimer > 0) {
            Time.timeScale = 0;
            myTimer -= step;
            var render = number.GetComponent("SpriteRenderer") as SpriteRenderer;
            if (render != null) {
                render.sprite = sprites[(int)(myTimer/interval)];
            }
        }
        if (myTimer <= 0) {
            Time.timeScale = 1;
            number.SetActive(false);
        }
    }
}
