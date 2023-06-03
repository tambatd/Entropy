using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EndingManager : MonoBehaviour {
    public static int John_Dalton;
    public static int Gen_Aiura;
    public static int Samuel_Bolton;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Gen_Aiura == 1 && John_Dalton == 1 && Samuel_Bolton == 1)
        {
            SceneManager.LoadScene("Ending Fire");
        }
	}
}
