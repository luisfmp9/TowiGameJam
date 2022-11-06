using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour{
    
    public static Timer timerSg;
    public float timer;
    public Text timerTxt;

    void Awake(){
        if(timerSg!=null && timerSg!=this){
            Destroy(this);
        } else{
            timerSg=this;
        }
    }

    void Start(){
        timer= 10f;
        
    }

    void Update(){
        if(timer>=0){
            timer -= Time.deltaTime;
            timerTxt.text=timer.ToString("F0");
        }
    }

}