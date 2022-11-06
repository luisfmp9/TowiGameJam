using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Enemy : MonoBehaviour{

    public Detector detectScript;
    public bool started;
    private Timer timeUI;
    void Awake() {
        started = false;
        timeUI= GameObject.FindGameObjectWithTag("Timer").GetComponent<Timer>();
    }

    void Update() {
        DetectPlayer();
    }

    void DetectPlayer() {
        if (detectScript.deply && !started) {
            started = true;
            timeUI.Battle();
        }
    }
    
}