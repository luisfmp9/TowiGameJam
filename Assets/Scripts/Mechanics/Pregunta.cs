using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Pregunta : MonoBehaviour{

    public float respuestaCorrecta;
    private int variable1, variable2;
    public Enemy starting;
    public Text texter;
    void Awake() {
        variable1 = Random.Range(0, 4);
        variable2 = Random.Range(0, 5);
        respuestaCorrecta = variable1 * variable2;
        texter.text = variable1 + " X " + variable2 + " ?";
    }
}