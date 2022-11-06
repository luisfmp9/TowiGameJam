using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour{

    public Detector detectScript;
    public bool started;
    
    void Awake() {
        started = false;
    }

    void Update() {
        DetectPlayer();
    }

    void DetectPlayer() {
        if (detectScript.deply) {
            started = true;
        }
    }
    
}