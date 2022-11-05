using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXBoton : MonoBehaviour{

    public AudioClip Clip;
    private AudioSource fuente;

    void Start(){
        fuente=GetComponent<AudioSource>();
    }
    
    public void Sonar(){
        fuente.clip=Clip;
        fuente.Play();
    }

}