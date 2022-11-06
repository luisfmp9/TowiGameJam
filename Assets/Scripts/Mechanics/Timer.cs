using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour{
    
    public static Timer timerSg;
    public float timer;
    public Text timerTxt;
    public bool battle;
    void Awake(){
        if(timerSg!=null && timerSg!=this){
            Destroy(this);
        } else{
            timerSg=this;
        }
    }

    public void Battle(){
        timer = 10;
    }

    void Update(){
        BattleTime();
    }
    void BattleTime()
    {
        if (timer > 0)
        {
            battle = true;
            timer -= Time.deltaTime;
            timerTxt.text = timer.ToString("F0");
            if (timer <= 0)
            {
                timer = 0;
            }
        }
    }

}