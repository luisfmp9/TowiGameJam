using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class contarClicks : MonoBehaviour {
    
    Text cantidadClicksTxt;
    int cantidadClicks;

    void Start(){
        cantidadClicks=0;
    }

    void Update(){
        if(Input.GetMouseButtonDown(0) && Timer.timerSg.timer>0){
            cantidadClicks++;
            cantidadClicksTxt.text=cantidadClicks.ToString();
        }
    }

}