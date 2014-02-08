using UnityEngine;
using System.Collections;

public class MainMenuScript : MonoBehaviour {

	public GUISkin mySkin;
	public Texture fightButton;
	public Texture chopButton;
	public Texture exitButton;
    public GameObject GateScript;

    private bool isFightButton = false;
    private bool isChopButton = false;
    private bool isExitButton = false;
    private Gate gate;

	// Use this for initialization
	void Start () {
        gate = GateScript.GetComponent<Gate>();

	}
	
	// Update is called once per frame
	void Update () {
        if (gate.isOpenedGate()) {
            Debug.Log("Gate opened");
            if (isFightButton)
                Application.LoadLevel(1);
            if (isChopButton)
                Application.LoadLevel(2);
            if (isExitButton)
                Application.Quit();
        }
	}

	void OnGUI() {
        if (gate.isOpeningGate())
            return;
		GUI.skin = mySkin;
		if (GUI.Button(new Rect(Screen.width / 2 - 230, Screen.height / 2 - 40, 140, 80), fightButton)) {
            gate.openGate();
            isFightButton = true;
		}
		if (GUI.Button(new Rect(Screen.width / 2 - 70, Screen.height / 2 - 40, 140, 80), chopButton)) {
            gate.openGate();
            isChopButton = true;
        }
		if (GUI.Button(new Rect(Screen.width / 2 + 90, Screen.height / 2 - 40, 140, 80), exitButton)) {
            gate.openGate();
            isExitButton = true;
        }
	}
}
