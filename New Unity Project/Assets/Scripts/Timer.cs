﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float time = 5;

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, time);
    }
}
