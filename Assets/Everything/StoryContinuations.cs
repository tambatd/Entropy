using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryContinuations : MonoBehaviour {
    private bool U1;
	// Use this for initialization
	void Start () {
        U1 = true;
	}
	
	// Update is called once per frame
	void Update () {
        if (U1 == true) {
            if (City_One.CityOne == 1 && City_Two.CityTwo == 1 && City_Three.CityThree == 1 && City_Four.CityFour == 1)
            {
                Story_Text_Main.story = 20;
                U1 = false;
            }
        }
    }
}
