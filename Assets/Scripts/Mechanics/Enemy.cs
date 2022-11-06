using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Enemy : MonoBehaviour{

    public Detector detectScript;
    public bool started;
    public GameObject panel;
    private contarClicks countClicker;
    void Awake() {
        started = false;
        countClicker = GameObject.FindGameObjectWithTag("Counter").GetComponent<contarClicks>();
    }

    void Update() {
        DetectPlayer();
    }

    void DetectPlayer() {
        if (detectScript.deply && !started) {
            started = true;
            panel.SetActive(true);
            Timer.timerSg.Battle();
            countClicker.protector = gameObject;
            countClicker.preguntaN = gameObject.GetComponent<Pregunta>();
        }
    }
    
}