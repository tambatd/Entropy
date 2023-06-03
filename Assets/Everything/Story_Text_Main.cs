using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Story_Text_Main : MonoBehaviour {
    Text ST;
    public static bool intro;
    public static int story;
    

    // Use this for initialization
    void Start () {
        intro = false;
        story = 1;
	}
	
	// Update is called once per frame
	void Update () {
        switch (story)
        {
            case 1:
                ST.text = "Hermes: Good Morning sir, congradulations on the promotion. THE BOARD HOPES TO SEE MONUMENTAL GROWTH UNDER YOUR LEADERSHIP.";
                break;
            case 2:
                ST.text = "Hermes: LET’S GET STRAIGHT TO WORK THEN.";
                break;
            case 3:
                ST.text = "Hermes: DUE TO THE COMMERCIAL SUCCESS OF THE NUROSCAPE, IT APPEARS THAT WE HAVE 600 MILLION IN EXCESS SPENDING CAPITAL AVAILABLE. ";
                break;
            case 4:
                ST.text = "Hermes: THROUGH OUR INFORMANTS WITHIN ARYA MEI, IT SEEMS AS IF THEY’VE BEEN WORKING ON A WAY TO INTERCONNECT THEIR EXOSKELETONS WITH HUMAN SPINAL CORDS. ";
                break;
            case 5:
                ST.text = "Hermes: IF THIS HOLDS TRUE, ARYA MEI WOULD BE INFRINGING ON MULTIPLE OF OUR PATENTS.";
                break;
            case 6:
                ST.text = "Hermes: IT SEEMS AS IF A HOSTILE TAKE OVER IS OUR ONLY CHOICE.";
                break;
            ///SIDEMISSION ENTROPY SERVER ISSUES///
            case 20:
                ST.text = "There seems to be something wrong with one of our entropy servers.";
                mang.stop = 1;

                break;
            case 21:
                ST.text = "There's multiple errors in the temp and log depository, for some reason we're not able to store user logs";
                break;
            case 22:
                ST.text = "Option one is that we delete all data costing 800 million in damages, or option two is that we simply ignore it.";
                break;
           ///SIDE MISSION END///
        }



    }
    private void Awake()
    {
        ST = GetComponent<Text>();

    }
    void continuestory()
    {

    }
}
