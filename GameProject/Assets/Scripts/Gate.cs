using UnityEngine;
using System.Collections;

public class Gate : MonoBehaviour {

    public float moveSpeed = 1f;
    public float left = -0.8f;
    public float rigth = -12f;
    public GameObject leftGate;
    public GameObject rigthGate;

    public bool isOpen = false;

    public void openPanel() {
        isOpen = true;
    }

    public void closePanel() {
        isOpen = false;
    }

    public bool isOpenPanel() {
        return isOpen;
    }

    private void moveLefth() {
        if (leftGate == null) {
            Debug.Log("leftGate not found!");
            return;
        }

        Vector3 pos = leftGate.transform.position;
        if (pos.x > left) {
            pos.x -= moveSpeed;
            if (pos.x < left - 1) {
                pos.x = left;
            }
            leftGate.transform.position = pos;
        }
    }

    private void moveRigth() {
        if (rigthGate == null) {
            Debug.Log("rigthGate not found!");
            return;
        }
        Vector3 pos = rigthGate.transform.position;
        if (pos.x < rigth) {
            pos.x += moveSpeed;
            if (pos.x > rigth + 1) {
                pos.x = rigth;
            }
            rigthGate.transform.position = pos;
        }
    }

    private bool checkGate() {
        if (leftGate == null || rigthGate == null) {
            Debug.LogError("Gate not found!!!");
            return false;
        }
        return true;
    }

    void Start() {
    }

    void Update() {
        if (!checkGate())
            return;
        if (isOpen) {
            moveLefth();
            moveRigth();
        }
    }
}
