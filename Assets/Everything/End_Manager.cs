using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class End_Manager : MonoBehaviour {
    public static int John_Dalton;
    public static int Gen_Aiura;
    public static int Samuel_Bolton;
    public static int Money;
    public static int Ending_Virus;
    public static int Ending_ServerLeak;
    // Use this for initialization
    void Start () {
        Application.targetFrameRate = 30;

    }
	
	// Update is called once per frame
	void Update () {
        if (FIRE.Gen_Aiura == 1 && FIRE.John_Dalton == 1 && FIRE.Samuel_Bolton == 1)
        {
            SceneManager.LoadScene("Ending_Fire");
        }
        if (Money_Int_Change.Money <= 0)
        {
            SceneManager.LoadScene("Ending_Bankruptcy");
        }
        if(Ending_Virus == 1)
        {
            SceneManager.LoadScene("Ending_Virus");
        }
        if(Ending_ServerLeak == 1)
        {
            SceneManager.LoadScene("Ending_ServerLeak");
        }

    }
}
