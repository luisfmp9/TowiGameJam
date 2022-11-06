using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class contarClicks : MonoBehaviour {
    
    public Text cantidadClicksTxt;
    int cantidadClicks;
    public Pregunta preguntaN;
    public GameObject protector, panelPerdiste;
    public EscenManager esManager;

    void Start(){
        cantidadClicks=0;
    }

    void Update(){
        if(Input.GetMouseButtonDown(0) && Timer.timerSg.timer>0){
            cantidadClicks++;
            cantidadClicksTxt.text=cantidadClicks.ToString();
        } else if (Timer.timerSg.timer<=0&& Timer.timerSg.battle)
        {
            if(cantidadClicks==preguntaN.respuestaCorrecta){
                Destroy(protector);
                Timer.timerSg.battle = false;
            } else {
                esManager.AbrirUI(panelPerdiste);
            }
        }
    }

}