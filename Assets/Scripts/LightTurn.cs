﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightTurn : MonoBehaviour
{
    public GameObject light;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LightOn()
    {
        if (light.activeSelf)
        {
            light.SetActive(false);
        } else
        {
            light.SetActive(true);
        }
    }
}
