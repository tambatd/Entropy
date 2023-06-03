using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Control3 : MonoBehaviour
    

{
    public Sprite threebb;
    //City that's int can be variated between 1-4
    public int Ctwo;
    BoxCollider2D box2d;
    

    // Use this for initialization
    void Start () {
        box2d = GetComponent<BoxCollider2D>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = threebb;
        }

    }
}
