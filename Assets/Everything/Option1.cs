using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Option1 : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Click1()
    {
        
        switch (Story_Text_Main.story)
        {
            case 1:
                Story_Text_Main.story = 2;
                break;
            case 2:
                Story_Text_Main.story = 3;
                break;
            case 3:
                Story_Text_Main.story = 4;
                break;
            case 4:
                Story_Text_Main.story = 5;
                mang.stop = 0;

                break;
            case 5:
                Story_Text_Main.story = 6;
                break;
            case 6://
                break;
            case 7://
                break;
            case 8://
                break;
            case 9://
                break;
            case 20:
                Story_Text_Main.story = 21;
                mang.stop = 1;

                break;

            case 21:
                Story_Text_Main.story = 22;
                break;
            case 22:
                Story_Text_Main.story = 23;
                break;
            case 23:
                Money_Int_Change.Money -= 800;
                mang.stop = 0;

                Story_Text_Main.story = 24;
                break;
            case 14:
                break;
            case 15:
                break;
            case 16:
                break;
        }
        
        
    }
    public void Click2()
    {
        switch (Story_Text_Main.story)
        {
            case 1:
                Story_Text_Main.story = 2;
                mang.stop = 0;
                break;
            case 2:
                Story_Text_Main.story = 3;
                mang.stop = 0;

                break;
            case 3:
                mang.stop = 0;

                Story_Text_Main.story = 4;
                break;
            case 4:
                mang.stop = 0;

                Story_Text_Main.story = 5;
                mang.stop = 0;

                break;
            case 5:
                mang.stop = 0;

                Story_Text_Main.story = 6;
                break;
            case 6://
                break;
            case 7://
                break;
            case 8://
                break;
            case 9://
                break;
            case 20:
                Story_Text_Main.story = 21;
                mang.stop = 1;

                break;
            case 21:
                Story_Text_Main.story = 22;
                

                break;
            case 22:
                Story_Text_Main.story = 23;
                break;
            case 23:
                End_Manager.Ending_ServerLeak = 1;
                mang.stop = 1;
                break;
            case 14:
                break;
            case 15:
                break;
            case 16:
                break;
        }
    }
}
