using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detector : MonoBehaviour{

    public bool deply;
    public string naming;
    
    void Start() {
        deply = false;
    }

    void Update() {

    }

    void OnTriggerEnter2D(Collider2D col) {
        if (col.gameObject.tag == naming) {
            deply = true;
        }
    }

    void OnTriggerExit2D(Collider2D col) {
        if (col.gameObject.tag == naming) {
            deply = false;
        }
    }
    
}