﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : AnimatedEntity
{

    // Start is called before the first frame update
    void Start()
    {
        AnimationSetup();
    }

    // Update is called once per frame
    void Update()
    {
        AnimationUpdate();
    }
}
