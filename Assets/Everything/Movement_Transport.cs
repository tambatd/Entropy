﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_Transport : MonoBehaviour {
    public float speed = 1f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(speed * Time.deltaTime,0,0);

    }
}
