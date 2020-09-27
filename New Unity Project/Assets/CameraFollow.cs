﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    

    private Transform playerTransform ;

    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    
    void LateUpdate()
    {
        Vector3 temp = playerTransform.position;

        temp.x = playerTransform.position.x;

        transform.position = temp;
    }
}
