using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{
    public int number;
    private float time, dieTime;
    public bool destroyable;
    [HideInInspector]
    public bool dead, hurting, dying;

    void Start()
    {
        dead = false;
    }
    void Update()
    {
        Hurt();
    }

    void Hurt()
    {
        if (hurting)
        {
            time += Time.deltaTime;
            if (time >= 0.5f)
            {
                hurting = false;
                time = 0;
            }
        }
        if (dying)
        {
            dieTime += Time.deltaTime;
            if (dieTime >= 0.5f)
            {
                dying = false;
                dieTime = 0;
            }
        }
    }
    public void ChangeLife(int value)
    {
        number += value;
        if (value < 0 && number > 0)
        {
            hurting=true;
        }
        if (number <= 0)
        {
            dead = true;
            dying = true;
            if (destroyable&&dead)
            {
                Destroy(gameObject);
            }
        }
    }
}
