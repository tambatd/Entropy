using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Replace_News : MonoBehaviour {
    public static int Ctwo;
    public Sprite News_reel_one;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Replace1.Ctwo == 1)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = News_reel_one;
        }

    }
}
