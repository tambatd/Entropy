using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Companies : MonoBehaviour {
    public GameObject Panel;
    // Use this for initialization
    public void OpenPanel()
    {
        if (Panel != null)
        {
            bool isActive = Panel.activeSelf;

            Panel.SetActive(!isActive);
        }
    }
    




    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

}
