﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Riot_Movement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        gameObject.transform.Translate(Vector3.up * 0.01f);
	}
}
