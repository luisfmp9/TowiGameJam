using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour {

    public static Sound soundSG;
    public AudioSource sounder;
    void Awake()
    {
        if (soundSG != null && soundSG != this)
        {
            Destroy(gameObject);
        }
        else
        {
            soundSG = this;
            DontDestroyOnLoad(this.gameObject);
        }

    }
}