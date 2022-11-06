using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pregunta : MonoBehaviour
{
    public float variable1, variable2, respuestaCorrecta;
    public Enemy starting;
    // Start is called before the first frame update
    void Awake()
    {
        timer = 10;
        variable1 = Random.Range(0f, 4f);
        variable2 = Random.Range(0f, 5f);
        respuestaCorrecta = variable1 * variable2;
    }

    // Update is called once per frame
    void Update()
    {

    }


}
