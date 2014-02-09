using UnityEngine;
using System.Collections;

public class FlyBird : MonoBehaviour {

    public Vector3 scale = new Vector3(1, 1, 1);
    public float speed = 1;
    public float endPos;
    public float dY = .01f;
    public float timeDy = 1;
	public AudioClip birdSound;

    private Vector3 startPos;
    private GameObject bird;
    private float time;
    private bool isDead = false;


    // Use this for initialization
    void Start() {
        bird = this.gameObject;
        startPos = bird.transform.position;
        time = timeDy;
        SoundPlayer player = SoundPlayer.getInstance();
        player.play(birdSound);
        bird.transform.localScale = scale;

    }

    // Update is called once per frame
    void Update() {
        if (Time.timeScale == 0)
            return;
        Vector3 pos = bird.transform.position;
        if ((pos.x / endPos) > 1) {
            pos = startPos;
        }
        pos.y += dY;
        
        if (time > 0) {
            time -= Time.deltaTime;
        } else {
            time = timeDy;
            if (isDead) {
                timeDy = 0;
                time = 0;
                bird.transform.position = pos;
                var angle = bird.transform.localRotation;// = new Quaternion(0, 0, -90, -90);
                Debug.Log(angle);
                return;
            }
            dY *= -1;
        }
        pos.x += speed;
        bird.transform.position = pos;
    }

    void OnMouseUpAsButton() {
        dY = -.2f;
        bird.transform.localRotation = new Quaternion(0, 0, -1.0f, 1.0f);

        isDead = true;
    }
}
