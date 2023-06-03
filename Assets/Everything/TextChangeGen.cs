using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TextChangeGen : MonoBehaviour {
    public static int Gen_Aiura;
    Text GenText;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (FIRE.Gen_Aiura == 1)
        {
            GenText.text = "N/A";
        }
	}
    private void Awake()
    {
        GenText = GetComponent<Text>();

    }
}
