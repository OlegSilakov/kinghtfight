using UnityEngine;
using System.Collections;

public class FlyBird : MonoBehaviour {

    public Vector3 scale = new Vector3(1, 1, 1);
    public float speed = 1;
    public float endPos;
    public float dY = .01f;
    public float timeDy = 1;

    private Vector3 startPos;
    private GameObject bird;
    private float time;

    // Use this for initialization
    void Start() {
        bird = this.gameObject;
        startPos = bird.transform.position;
        time = timeDy;
    }

    // Update is called once per frame
    void Update() {
        if (Time.timeScale == 0)
            return;
        Vector3 pos = bird.transform.position;
        if ((pos.x / endPos) > 1) {
            pos = startPos;
        }
        pos.x += speed;
        pos.y += dY;
        if (time > 0) {
            time -= Time.deltaTime;
        } else {
            time = timeDy;
            dY *= -1;
        }
        bird.transform.position = pos;
        bird.transform.localScale = scale;
    }
}
