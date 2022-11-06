using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Detector detectScript;
    public bool started;
    // Start is called before the first frame update
    void Awake()
    {
        started = false;
    }

    // Update is called once per frame
    void Update()
    {
        DetectPlayer();
    }

    void DetectPlayer()
    {
        if (detectScript.deply)
        {
            started = true;
        }
    }
}
