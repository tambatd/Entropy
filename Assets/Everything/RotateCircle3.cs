using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCircle3 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(Vector3.forward * -90 * Time.deltaTime);
        //Upgrade Calc//
    }
}
