using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pregunta : MonoBehaviour{

    public float respuestaCorrecta;
    private int variable1, variable2;
    public Enemy starting;
    
    void Awake() {
        variable1 = Random.Range(0, 4);
        variable2 = Random.Range(0, 5);
        respuestaCorrecta = variable1 * variable2;
    }
}