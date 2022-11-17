using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class contarClicks : MonoBehaviour {
    
    public AudioClip ClipCorrecto, ClipInCorrecto;
    public Text cantidadClicksTxt;
    int cantidadClicks;
    public Pregunta preguntaN;
    public GameObject protector, panelPerdiste;
    public EscenManager esManager;
    private bool reproducido;

    void Start(){
        cantidadClicks=0;
        reproducido=false;
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
                cantidadClicks = 0;
                Sound.soundSG.sounder.clip=ClipCorrecto;
                Sound.soundSG.sounder.Play();
            } else {
                if(reproducido==false){
                    Sound.soundSG.sounder.clip=ClipInCorrecto;
                    Sound.soundSG.sounder.Play();
                    reproducido=true;
                }
                esManager.AbrirUI(panelPerdiste);
            }
        }
    }

}