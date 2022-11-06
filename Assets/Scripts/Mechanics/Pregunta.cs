using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pregunta : MonoBehaviour{

    public float respuestaCorrecta;
    private float variable1, variable2;
    public Enemy starting;
    
    void Awake() {
        variable1 = Random.Range(0f, 4f);
        variable2 = Random.Range(0f, 5f);
        respuestaCorrecta = variable1 * variable2;
    }

    void Update() {

    }


}