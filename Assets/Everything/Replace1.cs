using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Replace1 : MonoBehaviour {
    public Sprite threebb;
    //City that's int can be variated between 1-4
    public static int Ctwo;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnMouseDown()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = threebb;
        Ctwo = 1;
    }
}
