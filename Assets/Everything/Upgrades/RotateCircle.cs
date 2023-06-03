using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCircle : MonoBehaviour {
    public float speed = 1.5f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (UpgradeTree.EA == 0)
        {
            transform.Rotate(Vector3.forward * -90 * Time.deltaTime);
            //Upgrade Calc//
        }
        else if (UpgradeTree.EA == 1)
        {
            //
        }
    }
}
