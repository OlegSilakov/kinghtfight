using UnityEngine;
using System.Collections;

public class SoundPlayer {

    private static SoundPlayer player = new SoundPlayer();
    private bool isPlay = true;
    private AudioClip sound = null;


    private SoundPlayer() {}

    public static SoundPlayer getInstance() {
        return player;
    }

    public void mute() {
        isPlay = !isPlay;
    }

    public void turnOn() {
        isPlay = true;
    }

    public void turnOff() {
        isPlay = false;
    }

    public void setSound(AudioClip _sound) {
        sound = _sound;
    }

    public void play() {
        if (sound == null) {
            Debug.LogError("sound not found!");
            return;
        }
        if (!isPlay) {
            Debug.Log("sounds turn off!");
            return;
        }
        AudioSource.PlayClipAtPoint(sound, Vector2.zero);
    }

    public void play(AudioClip _sound) {
        sound = _sound;
        play();
    }

}
