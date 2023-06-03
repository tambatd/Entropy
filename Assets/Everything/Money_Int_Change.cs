using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Money_Int_Change : MonoBehaviour {
    public static int Money;

    Text text;
	// Use this for initialization
	void Awake () {
        text = GetComponent<Text>();
        Money = 1000;
	}
	
	// Update is called once per frame
	void Update () {
        text.text = "$:" + Money;
	}
}
