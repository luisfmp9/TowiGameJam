using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXBoton : MonoBehaviour{

    public AudioClip Clip;
    public void Sonar(){
        Sound.soundSG.sounder.clip=Clip;
        Sound.soundSG.sounder.Play();
    }

}